namespace TC3Model.DataModel.Classes
{
    public class ReferenceImage
    {
        public int ReferenceID { get; set; }
        public ReferenceBase Reference { get; set; }

        public int ImageID { get; set; }
        public Image Image { get; set; }
    }
}
