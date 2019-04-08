namespace TC3Model.DataModel.Classes
{
    public class StashImage
    {
        public int StashID { get; set; }
        public StashBase Stash { get; set; }

        public int ImageID { get; set; }
        public Image Image { get; set; }
    }
}
