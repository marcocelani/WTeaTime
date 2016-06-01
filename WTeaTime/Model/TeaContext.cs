namespace WTeaTime.Model
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class TeaContext
    {
        private const string DS_FILE = "ds.json";
        public List<TeaEntity> lstTeas { get; set; }

        public TeaContext()
        {
            lstTeas = new List<TeaEntity>();
            Console.WriteLine(Directory.GetCurrentDirectory());
            try
            {
                lstTeas = JsonConvert.DeserializeObject<List<TeaEntity>>(File.ReadAllText(Directory.GetCurrentDirectory() + "\\" + DS_FILE));
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                CreateNewConfigFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CreateNewConfigFile()
        {
            try
            {
                lstTeas.Add(new TeaEntity() { Title = "Black Tea", Min = 3, Sec = 0, Beep = true, Message = "Tea is ready!", ShowMex = true });
                lstTeas.Add(new TeaEntity() { Title = "Earl Grey", Min = 5, Sec = 0, Beep = true, Message = "Tea is ready!", ShowMex = true });
                lstTeas.Add(new TeaEntity() { Title = "Fruit Tea", Min = 8, Sec = 0, Beep = true, Message = "Tea is ready!", ShowMex = true });
                SaveChanges();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SaveChanges()
        {
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\" + DS_FILE, JsonConvert.SerializeObject(lstTeas));
        }

        public TeaEntity Find(string name)
        {
            if (name == null) return null;
            foreach (TeaEntity t in lstTeas)
            {
                if (t.Title.Equals(name))
                    return t;
            }
            return null;
        }
    }
}
