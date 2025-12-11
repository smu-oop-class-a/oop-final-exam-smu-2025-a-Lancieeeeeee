using SQLite;

namespace OOP.FinalTerm.Exam
{
    public class MovieModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateReleased { get; set; }
        public string Genre { get; set; }
        public string Cover { get; set; }
        public int Ratings { get; set; }

        #region methods [TOUCH IT NOT.]
       
        public bool SetCoverFromFile(string imagePath)
        {
            try
            {
                if (!File.Exists(imagePath))
                {
                    return false;
                }

                byte[] imageData = File.ReadAllBytes(imagePath);
                Cover = Convert.ToBase64String(imageData);
                return true;
            }
            catch
            {
                return false;
            }
        }

       
        public Image GetCoverImage()
        {
            try
            {
                if (string.IsNullOrEmpty(Cover))
                {
                    return null;
                }

                byte[] imageData = Convert.FromBase64String(Cover);
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                return null;
            }
        }

        public bool SaveCoverToFile(string outputPath)
        {
            try
            {
                if (string.IsNullOrEmpty(Cover))
                {
                    return false;
                }

                byte[] imageData = Convert.FromBase64String(Cover);
                File.WriteAllBytes(outputPath, imageData);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
