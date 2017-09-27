using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace DiceOut
{
    public sealed partial class Dieimage : UserControl
    {
        private const int NumFaces = 6;
        public Image[] Faces = new Image[NumFaces];
        public Dieimage()
        {
            this.InitializeComponent();
            CreateFaceArray();
        }

        private void CreateFaceArray()
        {
            Faces[0] = face1;
            Faces[1] = face2;
            Faces[2] = face3;
            Faces[3] = face4;
            Faces[4] = face5;
            Faces[5] = face6;
        }
        public void DisplayFace(int FaceID)
        {
            FaceID = FaceID - 1;
            for (int i = 0; i < NumFaces; i++)
            {
                if (i == FaceID)
                {
                    Faces[i].Visibility = Visibility.Visible;
                }
                else
                {
                    Faces[i].Visibility = Visibility.Collapsed;
                }
            }
        }
        

        
    }
}
