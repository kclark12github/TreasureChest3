#define UseFileInfo
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TC3Base
{
    public class TCBase : INotifyPropertyChanged
    {
        public TCBase() {
            AppName = Assembly.GetEntryAssembly().GetName().Name;
            AppVersion = Assembly.GetEntryAssembly().GetName().Version.ToString();
            UserName = "KCLARK";
            Database = "GGGSCP1.TreasureChest";
        }
        #region "Events"
        public event PropertyChangedEventHandler PropertyChanged;
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {
            if (!string.IsNullOrEmpty(propertyName) && PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #region "Properties"
        public string AppName { get; set; }
        public string AppVersion { get; set; }
        private string mDatabase = string.Empty;
        public string Database
        {
            get { return this.mDatabase; }
            set { if (value != this.mDatabase) { this.mDatabase = value; NotifyPropertyChanged(); }; }
        }
        private string mUserName = string.Empty;
        public string UserName {
            get { return this.mUserName; }
            set { if (value != this.mUserName) { this.mUserName = value; NotifyPropertyChanged(); }; }
        }
        #endregion
        #region "Methods"
        public enum ParseParts
        {
            DrvOnly = 1,
            DirOnly = 2,
            DirOnlyNoSlash = -2,
            DrvDir = 3,
            DrvDirNoSlash = -3,
            FileNameBase = 4,
            FileNameExt = 5,
            FileNameExtNoDot = -5,
            FileNameBaseExt = 6,
            DrvDirFileNameBase = 7,
            Protocol = 8,
            ServerOnly = 9,
            ServerShare = 10,
            ShareOnly = 11
        }
        public static string ApplicationPath()
        {
            Assembly EntryAssembly = Assembly.GetEntryAssembly();
            if (!(EntryAssembly == null)) return string.Empty;
            string path = EntryAssembly.Location;
            //FileInfo: "URI formats are not supported."
            if (ParsePath(path, ParseParts.Protocol) == "file://") path = path.Substring("file:///".Length);
            return new FileInfo(path).DirectoryName;
        }
        public static string ParsePath(string strPath, ParseParts intPart)
        {
            string functionReturnValue = null;
            functionReturnValue = string.Empty;
            if ((strPath == null))
                strPath = string.Empty;
            if (strPath.Trim() == string.Empty)
                return functionReturnValue;
#if UseFileInfo
			FileInfo fi = null;
			string Protocol = string.Empty;
			string Drv = string.Empty;
			string ServerShare = string.Empty;
			string ServerOnly = string.Empty;
			string ShareOnly = string.Empty;
			bool WildCardFound = false;
			bool isPath = true;
			bool isUNC = false;
			//bool isURI = false;
			try {
				//First check for URI specification...
				if (strPath.ToLower().StartsWith("file://")) {
					//isURI = true;
					Protocol = "file://";
					if (intPart == ParseParts.Protocol)
						return Protocol;
					//Path will be in any of the following formats:
					//   file:///S:/FiRRe/... (note the extra "/" before the drive letter)...
					//   file://\\WSRV08/SunGard/FiRRe/...
					//   file://WWS004/SunGard/FiRRe/...
					if (strPath.ToLower().StartsWith("file:///") && strPath.Substring(9, 1) == ":") {
						strPath = strPath.Substring("file:///".Length).Replace("/", "\\");
					} else if (strPath.ToLower().StartsWith("file://\\\\")) {
						strPath = strPath.Substring("file://".Length).Replace("/", "\\");
					} else if (strPath.ToLower().StartsWith("file://") && strPath.IndexOf(":", "file://".Length) == -1) {
						strPath = strPath.Substring("file:".Length).Replace("/", "\\");
					} else {
						throw new NotSupportedException(string.Format("FILE protocol pattern ({0}) not recognized by ParsePath", strPath));
					}
				} else if (strPath.ToLower().StartsWith("http://")) {
					//isURI = true;
					throw new NotSupportedException(string.Format("HTTP protocol pattern ({0}) not supported by ParsePath", strPath));
				} else if (strPath.ToLower().StartsWith("https://")) {
					//isURI = true;
					throw new NotSupportedException(string.Format("HTTPS protocol pattern ({0}) not supported by ParsePath", strPath));
				}

				//OK, not that any file:// has been stripped off, see if we have a UNC or traditional pathname provided...
				if (strPath.StartsWith("\\\\")) {
					isUNC = true;
					ServerShare = strPath.Substring(2, strPath.IndexOf("\\", strPath.IndexOf("\\", 2) + 1) - 2);
					ServerOnly = ServerShare.Substring(0, ServerShare.IndexOf("\\"));
					ShareOnly = ServerShare.Substring(ServerShare.IndexOf("\\") + 1);
				} else {
					if (strPath.Length < "C:\\".Length)
						throw new NotSupportedException(string.Format("Invalid path ({0})", strPath));
					if (strPath.Substring(1, 1) == ":") {
						Drv = strPath.Substring(0, 2);
					//We weren't given a path at all, but a simple filename...
					} else {
						isPath = false;
					}
				}
				//If our would-be path contains any wild-cards, FileInfo will throw an exception, so deal with that here...
				if (strPath.IndexOf("*") > -1){WildCardFound = true;strPath = strPath.Replace("*", "XXXXXXXX");}

				fi = new FileInfo(strPath);
				switch (intPart) {
					case ParseParts.DrvOnly:
						return Drv;
					case ParseParts.ServerShare:
						return ServerShare;
					case ParseParts.ServerOnly:
						return ServerOnly;
					case ParseParts.ShareOnly:
						return ShareOnly;
					case ParseParts.DirOnly:
						if (!isPath)
							return string.Empty;
						if (isUNC)
							return string.Format("{0}\\", fi.DirectoryName.Substring("\\\\".Length + ServerShare.Length));
						return string.Format("{0}\\", fi.DirectoryName.Substring(Drv.Length));
					case ParseParts.DirOnlyNoSlash:
						if (!isPath)
							return string.Empty;
						if (isUNC)
							return fi.DirectoryName.Substring("\\\\".Length + ServerShare.Length);
						return fi.DirectoryName.Substring(Drv.Length);
					case ParseParts.DrvDir:
						if (isPath)
							return string.Format("{0}\\", fi.DirectoryName);
						else
							return string.Empty;
					case ParseParts.DrvDirNoSlash:
						if (isPath)
							return fi.DirectoryName;
						else
							return string.Empty;
					case ParseParts.DrvDirFileNameBase:
						if (isPath)
							return fi.FullName.Substring(0, fi.FullName.Length - fi.Extension.Length);
						else
							return string.Empty;
					case ParseParts.FileNameBaseExt:
						return fi.Name;
					case ParseParts.FileNameBase:
						return fi.Name.Substring(0, fi.Name.Length - fi.Extension.Length);
					case ParseParts.FileNameExt:
						return fi.Extension;
					case ParseParts.FileNameExtNoDot:
						return fi.Extension.Substring(1);
				}
			} finally {
				if (WildCardFound)
					functionReturnValue = functionReturnValue.Replace("XXXXXXXX", "*");
				fi = null;
			}
#else
            short intCPos = 0;
            short intLPos = 0;
            short intTemp = 0;
            short intPathStart = 0;
            short intPathLen = 0;
            string strPart1 = string.Empty;
            string strPart2 = string.Empty;
            string strPart4 = string.Empty;
            string strPart5 = string.Empty;
            functionReturnValue = string.Empty;

            intPathLen = (short)strPath.Length;

            //Get the Protocol (if any)...
            intCPos = (short)strPath.IndexOf("://");
            if (intCPos > 0)
            {
                if (intPart == ParseParts.Protocol) { strPath = Strings.Left(strPath, intCPos + "://".Length); return functionReturnValue; }
                //If we don't want the Protocol, strip it off so it won't interfere with any logic below...
                switch (Strings.LCase(ParseStr(strPath, 1, "://")))
                {
                    case "file":
                        //Path will be in any of the following formats:
                        //   file:///S:/FiRRe/... (note the extra "/" before the drive letter)...
                        //   file://\\WSRV08/SunGard/FiRRe/...
                        //   file://WWS004/SunGard/FiRRe/...
                        if (strPath.ToLower().StartsWith("file:///") && strPath.Substring(9, 1) == ":")
                        {
                            strPath = strPath.Substring("file:///".Length).Replace("/", "\\");
                        }
                        else if (strPath.ToLower().StartsWith("file://\\\\"))
                        {
                            strPath = strPath.Substring("file://".Length).Replace("/", "\\");
                        }
                        else if (strPath.ToLower().StartsWith("file://") && strPath.IndexOf(":", "file://".Length) == -1)
                        {
                            strPath = strPath.Substring("file:".Length).Replace("/", "\\");
                        }
                        else
                        {
                            throw new NotSupportedException(string.Format("FILE protocol pattern ({0}) not not recognized by ParsePath", strPath));
                        }
                        intPathLen = strPath.Length;
                        break;
                    case "http":
                        throw new NotSupportedException("HTTP protocol not currently supported by ParsePath");
                }
            }

            //Get drive portion.
            intCPos = Strings.InStr(strPath, ":");
            if (intCPos)
                strPart1 = Strings.Left(strPath, intCPos);

            //Get path portion.
            intLPos = Strings.InStr(1, strPath, "\\");
            if (Strings.Right(strPath, 1) == "\\")
            {
                //strPath contains no filename.
                if (intPathLen > intLPos)
                {
                    if (intPart < 0)
                    {
                        strPart2 = Strings.Mid(strPath, intLPos, intPathLen - intLPos);
                    }
                    else
                    {
                        strPart2 = Strings.Mid(strPath, intLPos);
                    }
                }
                else
                {
                    strPart2 = "\\";
                }

            }
            else
            {
                if (intLPos)
                {
                    //strPath must contain a filename.
                    intPathStart = intLPos;
                    intLPos = intLPos + 1;

                    do
                    {
                        intCPos = Strings.InStr(intLPos, strPath, "\\");
                        if (intCPos)
                        {
                            intLPos = intCPos + 1;
                        }
                    } while (intCPos);

                    if (intPart < 0)
                    {
                        strPart2 = Strings.Mid(strPath, intPathStart, intLPos - intPathStart - 1);
                    }
                    else
                    {
                        strPart2 = Strings.Mid(strPath, intPathStart, intLPos - intPathStart);
                    }
                }
                else
                {
                    //No path was found.
                    if (Strings.Len(strPart1))
                    {
                        //If drive spec, start at position 3 when getting filename portion.
                        intLPos = 3;
                    }
                    else
                    {
                        intLPos = 1;
                    }
                }

                strPart4 = Strings.Mid(strPath, intLPos);

                //Check if filename base has extension.
                intCPos = 1;
                do
                {
                    intTemp = Strings.InStr(intCPos + 1, strPart4, ".");
                    if (intTemp)
                        intCPos = intTemp;
                } while (intTemp);

                if (intCPos > 1)
                {
                    //Get filename extension portion.
                    // Check if it's "negative".
                    if (Strings.InStr(Convert.ToString(intPart), "-"))
                    {
                        strPart5 = Strings.Mid(strPart4, intCPos + 1);
                    }
                    else
                    {
                        strPart5 = Strings.Mid(strPart4, intCPos);
                    }
                    strPart4 = Strings.Left(strPart4, intCPos - 1);
                    //Get filename base portion.
                }
            }

            switch (intPart)
            {
                case ParseParts.DrvOnly:
                    functionReturnValue = strPart1;
                    break;
                case ParseParts.DirOnly:
                case ParseParts.DirOnlyNoSlash:
                    functionReturnValue = strPart2;
                    break;
                case ParseParts.DrvDir:
                case ParseParts.DrvDirNoSlash:
                    functionReturnValue = strPart1 + strPart2;
                    break;
                case ParseParts.FileNameBase:
                    functionReturnValue = strPart4;
                    break;
                case ParseParts.FileNameExt:
                case ParseParts.FileNameExtNoDot:
                    functionReturnValue = strPart5;
                    break;
                case ParseParts.FileNameBaseExt:
                    functionReturnValue = strPart4 + strPart5;
                    break;
                case ParseParts.DrvDirFileNameBase:
                    functionReturnValue = strPart1 + strPart2 + strPart4;
                    break;
                case ParseParts.Protocol:
                    functionReturnValue = strPart1;
                    break;
            }
#endif
            return functionReturnValue;
        }
        #endregion
        #region "Event Handlers"
        #endregion
    }
}
