using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing
{
    // TODO: SomeType örneklerinde hata ayıklarken görselleştiriciyi görmek için aşağıdakileri SomeType'ın tanımına ekleyin:
    // 
    //  [DebuggerVisualizer(typeof(Visualizer1))]
    //  [Serializable]
    //  public class SomeType
    //  {
    //   ...
    //  }
    // 
    /// <summary>
    /// SomeType için Görselleştirici.  
    /// </summary>
    public class Visualizer1 : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            if (windowService == null)
                throw new ArgumentNullException("windowService");
            if (objectProvider == null)
                throw new ArgumentNullException("objectProvider");

            // TODO: Bir görselleştiriciyi görüntüleyecek nesneyi alın.
            //       objectProvider.GetObject() sonucunu 
            //       görselleştirilen nesnenin türüne ata.
            object data = (object)objectProvider.GetObject();

            // TODO: Nesnenin görünümünü görüntüleyin.
            //       displayForm'u kendi özel Form'unuz ya da Denetim'iniz ile değiştirin.
            using (Form displayForm = new Form())
            {
                displayForm.Text = data.ToString();
                windowService.ShowDialog(displayForm);
            }
        }

        // TODO: Görselleştiriciyi sınamak için sınama kodunuza aşağıdakileri ekleyin:
        // 
        //    Visualizer1.TestShowVisualizer(new SomeType());
        // 
        /// <summary>
        /// Görselleştiriciyi hata ayıklayıcının dışında barındırarak sınar.
        /// </summary>
        /// <param name="objectToVisualize">Görselleştiricide görüntülenecek nesne.</param>
        public static void TestShowVisualizer(object objectToVisualize)
        {
            VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(Visualizer1));
            visualizerHost.ShowVisualizer();
        }
    }
}
