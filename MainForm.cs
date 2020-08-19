
/*
 * Created by SharpDevelop.
 * User: casper
 * Date: 4.08.2020
 * Time: 23:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace tridiModellerThingy
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        int contents = 0;
        double dd = 0.5;

        int rotX = 0;
        int rotY = 0;

        string coderequied;
        string[] codestore = {
      "begin"
    };
        string[] codestore2 = {
      "begin"
    };

        float[] light_diffuse = {
      1.0f,
      1.0f,
      1.0f,
      1.0f
    };

        float[] specular = {
      1.0f,
      1.0f,
      1.0f,
      1.0f
    };

        float[] red = {
      1.0f,
      0.0f,
      0.0f,
      1.0f
    };

        float[] green = {
      0.0f,
      1.0f,
      0.0f,
      1.0f
    };

        float[] blue = {
      0.0f,
      0.0f,
      1.0f,
      1.0f
    };
        double tra_x = 0.0,
        tra_y = 0.0,
        tra_z = 0.0;

        float[] shine = {
      20.0f
    };

        bool isShine = false;

        bool rightclick = false;

        bool isSmooth = true;

        //	string[] variable;
        int test_rot = 0;
        float[] brass_ambient = {
      0.33f,
      0.22f,
      0.03f,
      1.0f
    },
        brass_diffuse = {
      0.78f,
      0.57f,
      0.11f,
      1.0f
    },
        brass_specular = {
      0.99f,
      0.91f,
      0.81f,
      1.0f
    };
        float brass_shininess = 27.8f;

        string color_q;
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        void Button2Click(object sender, EventArgs e)
        {

            coderequied = textBox1.Text.ToString();

            //MessageBox.Show(textBox1.ToString());

            String line = "E";

            for (int i = 0; i < 1; i++)
            {

                line = coderequied;
                char[] delimiters = new char[] {
          ' ',
          '\t'
        };

                //   MessageBox.Show(line);
                codestore = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            }

            contents = textBox1.Text.ToString().Remove(textBox1.Text.Length - 1).Split(' ').Length
            /*;*/
            ;

        }

        void GlControl1Load(object sender, EventArgs e)
        {
            base.OnLoad(e);
            GL.Enable(EnableCap.DepthTest);
            GL.Enable(EnableCap.Fog);
            GL.Fog(FogParameter.FogMode, Convert.ToSingle(FogMode.Linear));
            GL.Fog(FogParameter.FogEnd, 2000);

            GlControl1Resize(this, EventArgs.Empty); // Ensure the Viewport is set up correctly
                                                     //GL.ClearColor(Color.Crimson);
        }

        void Sphere(double r, int lats, int longs, float x2, float y2, float z2)
        {

            int i,
            j;
            for (i = 0; i <= lats; i++)
            {
                double lat0 = Math.PI * (-0.5 + (double)(i - 1) / lats);
                double z0 = Math.Sin(lat0);
                double zr0 = Math.Cos(lat0);

                double lat1 = Math.PI * (-0.5 + (double)i / lats);
                double z1 = Math.Sin(lat1);
                double zr1 = Math.Cos(lat1);

                GL.PushMatrix();
                GL.Translate(x2, y2, z2);
                GL.Begin(BeginMode.QuadStrip);

                for (j = 0; j <= longs; j++)
                {
                    double lng = 2 * Math.PI * (double)(j - 1) / longs;
                    double x = Math.Cos(lng);
                    double y = Math.Sin(lng);

                    GL.Normal3(x * zr0, y * zr0, z0);
                    GL.Vertex3(r * x * zr0, r * y * zr0, r * z0);
                    GL.Normal3(x * zr1, y * zr1, z1);
                    GL.Vertex3(r * x * zr1, r * y * zr1, r * z1);
                }
                GL.End();
                GL.PopMatrix();
            }

        }
        void Cube(float x, float y, float z, float size_x, float size_y, float size_z)
        {
            if (isSmooth == false)
            {
                GL.PushMatrix();
                GL.Translate(x, y, z);
                GL.Scale(size_x, size_y, size_z);
                GL.Begin(PrimitiveType.Quads);

                GL.Normal3(0.0000, 1.0000, 0.0000);
                // Front Face
                GL.TexCoord2(0.0f, 0.0f);
                GL.Vertex3(-1.0f, -1.0f, 1.0f); // Bottom Left Of The Texture and Quad
                GL.TexCoord2(1.0f, 0.0f);
                GL.Vertex3(1.0f, -1.0f, 1.0f); // Bottom Right Of The Texture and Quad
                GL.TexCoord2(1.0f, 1.0f);
                GL.Vertex3(1.0f, 1.0f, 1.0f); // Top Right Of The Texture and Quad
                GL.TexCoord2(0.0f, 1.0f);
                GL.Vertex3(-1.0f, 1.0f, 1.0f); // Top Left Of The Texture and Quad
                                               // Back Face
                GL.Normal3(0.0000, 0.0000, 1.0000);
                GL.TexCoord2(1.0f, 0.0f);
                GL.Vertex3(-1.0f, -1.0f, -1.0f); // Bottom Right Of The Texture and Quad
                GL.TexCoord2(1.0f, 1.0f);
                GL.Vertex3(-1.0f, 1.0f, -1.0f); // Top Right Of The Texture and Quad
                GL.TexCoord2(0.0f, 1.0f);
                GL.Vertex3(1.0f, 1.0f, -1.0f); // Top Left Of The Texture and Quad
                GL.TexCoord2(0.0f, 0.0f);
                GL.Vertex3(1.0f, -1.0f, -1.0f); // Bottom Left Of The Texture and Quad
                                                // Top Face
                GL.Normal3(0.0000, 1.0000, 0.0000);
                GL.TexCoord2(0.0f, 1.0f);
                GL.Vertex3(-1.0f, 1.0f, -1.0f); // Top Left Of The Texture and Quad
                GL.TexCoord2(0.0f, 0.0f);
                GL.Vertex3(-1.0f, 1.0f, 1.0f); // Bottom Left Of The Texture and Quad
                GL.TexCoord2(1.0f, 0.0f);
                GL.Vertex3(1.0f, 1.0f, 1.0f); // Bottom Right Of The Texture and Quad
                GL.TexCoord2(1.0f, 1.0f);
                GL.Vertex3(1.0f, 1.0f, -1.0f); // Top Right Of The Texture and Quad
                GL.Normal3(0.0000, 1.0000, 0.0000);
                // Bottom Face
                GL.TexCoord2(1.0f, 1.0f);
                GL.Vertex3(-1.0f, -1.0f, -1.0f); // Top Right Of The Texture and Quad
                GL.TexCoord2(0.0f, 1.0f);
                GL.Vertex3(1.0f, -1.0f, -1.0f); // Top Left Of The Texture and Quad
                GL.TexCoord2(0.0f, 0.0f);
                GL.Vertex3(1.0f, -1.0f, 1.0f); // Bottom Left Of The Texture and Quad
                GL.TexCoord2(1.0f, 0.0f);
                GL.Vertex3(-1.0f, -1.0f, 1.0f); // Bottom Right Of The Texture and Quad
                                                //  GL.Normal3(0.0000,0.0000,1.0000);
                GL.Normal3(0.0000, 0.0000, 1.0000);
                // Right face
                GL.TexCoord2(1.0f, 0.0f);
                GL.Vertex3(1.0f, -1.0f, -1.0f); // Bottom Right Of The Texture and Quad
                GL.TexCoord2(1.0f, 1.0f);
                GL.Vertex3(1.0f, 1.0f, -1.0f); // Top Right Of The Texture and Quad
                GL.TexCoord2(0.0f, 1.0f);
                GL.Vertex3(1.0f, 1.0f, 1.0f); // Top Left Of The Texture and Quad
                GL.TexCoord2(0.0f, 0.0f);
                GL.Vertex3(1.0f, -1.0f, 1.0f); // Bottom Left Of The Texture and Quad
                                               // Left Face
                GL.Normal3(0.0000, 1.0000, 0.0000);

                GL.TexCoord2(0.0f, 0.0f);
                GL.Vertex3(-1.0f, -1.0f, -1.0f); // Bottom Left Of The Texture and Quad
                GL.TexCoord2(1.0f, 0.0f);
                GL.Vertex3(-1.0f, -1.0f, 1.0f); // Bottom Right Of The Texture and Quad
                GL.TexCoord2(1.0f, 1.0f);
                GL.Vertex3(-1.0f, 1.0f, 1.0f); // Top Right Of The Texture and Quad
                GL.TexCoord2(0.0f, 1.0f);
                GL.Vertex3(-1.0f, 1.0f, -1.0f); // Top Left Of The Texture and Quad
                GL.End();
                GL.PopMatrix();
                //GL.Light(LightName.Light0,LightParameter.Diffuse,light_diffuse);
            }

            if (isSmooth == true)
            {
                /*
                        GL.Light(LightName.Light0,LightParameter.SpotDirection,brass_specular);
                        GL.Material(MaterialFace.FrontAndBack,MaterialParameter.Ambient,brass_ambient);
                        GL.Material(MaterialFace.FrontAndBack,MaterialParameter.Shininess,brass_shininess);
                                    GL.Material(MaterialFace.FrontAndBack,MaterialParameter.Diffuse,brass_diffuse);
                                     GL.Material(MaterialFace.FrontAndBack,MaterialParameter.Specular,brass_specular);*/
                GL.PushMatrix();
                GL.Translate(x, y, z);
                GL.Scale(size_x, size_y, size_z);
                GL.Begin(PrimitiveType.Quads);

                //GL.Normal3(0.0000,1.0000,0.0000);
                // Front Face
                GL.Normal3(-0.5773, 0.5773, -0.5773);
                GL.TexCoord2(0.0f, 0.0f);
                GL.Vertex3(-1.0f, -1.0f, 1.0f); // Bottom Left Of The Texture and Quad
                GL.TexCoord2(1.0f, 0.0f);
                GL.Vertex3(1.0f, -1.0f, 1.0f); // Bottom Right Of The Texture and Quad
                GL.TexCoord2(1.0f, 1.0f);
                GL.Vertex3(1.0f, 1.0f, 1.0f); // Top Right Of The Texture and Quad
                GL.TexCoord2(0.0f, 1.0f);
                GL.Vertex3(-1.0f, 1.0f, 1.0f); // Top Left Of The Texture and Quad
                                               // Back Face
                GL.Normal3(0.0000, 1.0000, 0.0000);

                GL.TexCoord2(1.0f, 0.0f);
                GL.Vertex3(-1.0f, -1.0f, -1.0f); // Bottom Right Of The Texture and Quad
                GL.TexCoord2(1.0f, 1.0f);
                GL.Normal3(-0.5773, -0.5773, -0.5773);
                GL.Vertex3(-1.0f, 1.0f, -1.0f); // Top Right Of The Texture and Quad
                GL.TexCoord2(0.0f, 1.0f);
                GL.Vertex3(1.0f, 1.0f, -1.0f); // Top Left Of The Texture and Quad
                GL.TexCoord2(0.0f, 0.0f);
                GL.Normal3(0.0000, 1.0000, 0.0000);
                GL.Vertex3(1.0f, -1.0f, -1.0f); // Bottom Left Of The Texture and Quad
                                                // Top Face

                GL.TexCoord2(0.0f, 1.0f);
                GL.Normal3(-0.5773, -0.5773, -0.5773);
                GL.Vertex3(-1.0f, 1.0f, -1.0f); // Top Left Of The Texture and Quad
                GL.TexCoord2(0.0f, 0.0f);
                GL.Vertex3(-1.0f, 1.0f, 1.0f); // Bottom Left Of The Texture and Quad
                GL.TexCoord2(1.0f, 0.0f);
                GL.Vertex3(1.0f, 1.0f, 1.0f); // Bottom Right Of The Texture and Quad
                GL.TexCoord2(1.0f, 1.0f);
                GL.Vertex3(1.0f, 1.0f, -1.0f); // Top Right Of The Texture and Quad

                // Bottom Face
                GL.TexCoord2(1.0f, 1.0f);
                GL.Vertex3(-1.0f, -1.0f, -1.0f); // Top Right Of The Texture and Quad
                GL.TexCoord2(0.0f, 1.0f);
                GL.Normal3(0.5773, 0.5773, -0.5773);
                GL.Vertex3(1.0f, -1.0f, -1.0f); // Top Left Of The Texture and Quad
                GL.TexCoord2(0.0f, 0.0f);
                GL.Vertex3(1.0f, -1.0f, 1.0f); // Bottom Left Of The Texture and Quad
                GL.TexCoord2(1.0f, 0.0f);
                GL.Vertex3(-1.0f, -1.0f, 1.0f); // Bottom Right Of The Texture and Quad
                                                //  GL.Normal3(0.0000,0.0000,1.0000);
                                                // Right face
                GL.TexCoord2(1.0f, 0.0f);
                GL.Vertex3(1.0f, -1.0f, -1.0f); // Bottom Right Of The Texture and Quad
                GL.TexCoord2(1.0f, 1.0f);
                GL.Normal3(0.5773, -0.5773, -0.5773);
                GL.Vertex3(1.0f, 1.0f, -1.0f); // Top Right Of The Texture and Quad
                GL.TexCoord2(0.0f, 1.0f);
                GL.Vertex3(1.0f, 1.0f, 1.0f); // Top Left Of The Texture and Quad
                GL.TexCoord2(0.0f, 0.0f);
                GL.Vertex3(1.0f, -1.0f, 1.0f); // Bottom Left Of The Texture and Quad
                                               // Left Face

                GL.TexCoord2(0.0f, 0.0f);
                GL.Vertex3(-1.0f, -1.0f, -1.0f); // Bottom Left Of The Texture and Quad
                GL.TexCoord2(1.0f, 0.0f);
                GL.Vertex3(-1.0f, -1.0f, 1.0f); // Bottom Right Of The Texture and Quad
                GL.TexCoord2(1.0f, 1.0f);
                GL.Vertex3(-1.0f, 1.0f, 1.0f); // Top Right Of The Texture and Quad
                GL.TexCoord2(0.0f, 1.0f);
                GL.Vertex3(-1.0f, 1.0f, -1.0f); // Top Left Of The Texture and Quad
                GL.End();
                GL.PopMatrix();
                //GL.Light(LightName.Light0,LightParameter.Diffuse,light_diffuse);
            }
        }

        protected virtual bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null) stream.Close();
            }

            //file is not locked
            return false;
        }

        void model(string fileloc)
        {

            FileInfo file = new FileInfo(fileloc);
            if (IsFileLocked(file) == false)
            {
                string[] lines = System.IO.File.ReadAllLines(fileloc);
                string[] ohherewego = {
          "wutt"
        };
                string contenta = String.Concat(System.IO.File.ReadAllLines(fileloc));
                //  bool okshit = true;
                // if(okshit == true){
                //	  foreach (string line in lines)
                // {
                // Use a tab to indent each line of the file.
                string line = "e";
                line = contenta;
                char[] delimiters = new char[] {
          ' ',
          '\t'
        };

                ohherewego = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                int contents2 = contenta.Split(' ').Length
                /*;*/
                ;

                for (int i = 0; i < contents2;
                /*18*/
                /*;*/
                i++)
                {
                    if (ohherewego[i].Contains("begin_tri"))
                    {
                        GL.Begin(BeginMode.Triangles);
                    }
                    if (ohherewego[i].Contains("begin_triangle_strip"))
                    {
                        GL.Begin(BeginMode.TriangleStrip);
                    }
                    if (ohherewego[i].Contains("begin_triangle_fan"))
                    {
                        GL.Begin(BeginMode.TriangleFan);
                    }
                    if (ohherewego[i].Contains("begin_quads"))
                    {
                        GL.Begin(BeginMode.Quads);
                    }

                    if (ohherewego[i].Contains("begin_quad_strip"))
                    {
                        GL.Begin(BeginMode.QuadStrip);
                    }

                    if (ohherewego[i].Contains("nx"))
                    {

                        GL.Normal3(Single.Parse(ohherewego[i + 1]), Single.Parse(ohherewego[i + 2]), Single.Parse(ohherewego[i + 3]));
                        //GL.Normal3(Single.Parse(ohherewego[i+1]),Single.Parse(ohherewego[i+2]),Single.Parse(ohherewego[i+3]));
                    }

                    if (ohherewego[i].Contains("v"))
                    {

                        GL.Vertex3(Single.Parse(ohherewego[i + 1]), Single.Parse(ohherewego[i + 2]), Single.Parse(ohherewego[i + 3]));
                        //GL.Vertex3(Single.Parse(ohherewego[i+4]),Single.Parse(ohherewego[i+5]),Single.Parse(ohherewego[i+6]));
                        //	GL.Vertex3(Single.Parse(ohherewego[i+7]),Single.Parse(ohherewego[i+8]),Single.Parse(ohherewego[i+9]));                                                                                                                                  
                        //Application.Exit();
                    }

                    if (ohherewego[i].Contains("box"))
                    {

                        Cube(Single.Parse(ohherewego[i + 1]), Single.Parse(ohherewego[i + 2]), Single.Parse(ohherewego[i + 3]), Single.Parse(ohherewego[i + 4]), Single.Parse(ohherewego[i + 5]), Single.Parse(ohherewego[i + 6]));
                    }
                    if (ohherewego[i].Contains("end"))
                    {
                        GL.End();
                    }
                }
                //if (codestore[i].Contains("begin")){
                //	}

                //   okshit = false;
                // }
                // }
                //	  Console.WriteLine(String.Concat(ohherewego));

            }
        }

        //if (codestore[i].Contains("begin")){
        //	}

        //}
        void GlControl1Paint(object sender, PaintEventArgs e)
        {

            glControl1.MakeCurrent();
            // GL.ClearColor(Color.Crimson);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            float[] light_position = {
        0.0f,
        5.0f,
        4.0f,
        0.0f
      };
            /* Infinite light location. */
            GL.Light(LightName.Light0, LightParameter.Diffuse, light_diffuse);
            GL.Light(LightName.Light0, LightParameter.Position, light_position);
            GL.Enable(EnableCap.Light0);

            Matrix4 modelview = Matrix4.LookAt(Vector3.Zero, Vector3.UnitZ, Vector3.UnitY);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);

            if (isSmooth == true) GL.ShadeModel(ShadingModel.Smooth);

            if (isShine == true)
            {
                GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Specular, specular);
                GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Shininess, shine);

                //	GL.Enable(EnableCap.ColorMaterial);
            }

            GL.Enable(EnableCap.Lighting);
            GL.Rotate(-rotY, 1.0f, 0.0f, 0.0f);
            GL.Rotate(-rotX, 0.0f, 1.0f, 0.0f);
            GL.Translate(tra_x, tra_y, tra_z);

            GL.PushMatrix();
            //   test_rot++;
            // GL.Rotate(test_rot,1,0,0);
            GL.Disable(EnableCap.Lighting);
            // GL.BindTexture(TextureTarget.Texture2D, skybox);
            //  GL.Scale(30,30,30);
            // Cube(9,0,0,1,1,1);
            GL.Enable(EnableCap.Lighting);
            GL.PopMatrix();

            //   GL.PushMatrix()

            //	GL.PopMatrix();

            GL.Color3(Color.Silver);

            for (int i = 0; i < contents;
            /*18*/
            /*;*/
            i++)
            {

                //if (codestore[i].Contains("begin")){
                //	}
                if (codestore[i].Contains("height_map"))
                {

                }
                if (codestore[i].Contains("rotate"))
                {

                    GL.Rotate(Single.Parse(codestore[i + 1]), Single.Parse(codestore[i + 2]), Single.Parse(codestore[i + 3]), Single.Parse(codestore[i + 4]));
                }
                if (codestore[i].Contains("model"))
                {
                    GL.PushMatrix();
                    //	  GL.Rotate(test_rot,1,0,0);
                    GL.Translate(Single.Parse(codestore[i + 2]), Single.Parse(codestore[i + 3]), Single.Parse(codestore[i + 4]));
                    model(String.Format(@"models\{0}.rq3d", codestore[i + 1].ToString()));
                    GL.PopMatrix();
                }

                if (codestore[i].Contains("sphere"))
                {

                    Sphere(0.60, 40, 40, Single.Parse(codestore[i + 1]), Single.Parse(codestore[i + 2]), Single.Parse(codestore[i + 3])); //Sphere(0.60,40,40);
                }
                if (codestore[i].Contains("color"))
                {

                    float[] color = {
            Single.Parse(String.Format("0.{0}", codestore[i + 1])),
            Single.Parse(String.Format("0.{0}", codestore[i + 2])),
            Single.Parse(String.Format("0.{0}", codestore[i + 3])),
            1.0f
          };
                    //if (.Contains("red")){
                    //	 GL.Light(LightName.Light0,LightParameter.Diffuse,color);
                    GL.Material(MaterialFace.Front, MaterialParameter.Diffuse, color);
                    //}
                    //	if (codestore[i+5].Contains("green")){
                    // GL.Light(LightName.Light0,LightParameter.Diffuse,green);
                    //	}
                    //	if (codestore[i+5].Contains("blue")){
                    //	 GL.Light(LightName.Light0,LightParameter.Diffuse,blue);
                    //	}
                    //if (codestore[i+5].Contains("gray")){
                    //			 GL.Light(LightName.Light0,LightParameter.Diffuse,blue);
                    //		}
                }

                if (codestore[i].Contains("block"))
                {

                    try
                    {

                        float x;
                        float y;
                        float z;
                        float size_x;
                        float size_y;
                        float size_z;
                        bool heycollision = true;
                        //float z;
                        string conv;

                        x = Single.Parse(codestore[i + 1]);
                        y = Single.Parse(codestore[i + 2]);

                        z = Single.Parse(codestore[i + 3]);

                        size_x = Single.Parse(codestore[i + 4]);
                        size_y = Single.Parse(codestore[i + 5]);

                        size_z = Single.Parse(codestore[i + 6]);

                        //	GL.Begin(BeginMode.Polygon);
                        GL.PushMatrix();
                        Cube(x, y, z, size_x, size_y, size_z);

                        GL.Translate(0, 4, 5);
                        //	model(@"models\leg.rq3d");
                        GL.PopMatrix();

                    }
                    catch (Exception ex)
                    {

                    }

                    //GL.Vertex3(0.598f, -0.5f, 0f);
                    //  GL.Vertex3(-0.269f, -0.5f, 0.5f);

                    //	GL.Vertex3(Single.Parse(codestore[i+1]),Single.Parse(codestore[i+2]),Single.Parse(codestore[i+3]));
                    //	GL.Vertex3(Single.Parse(codestore[i+4]),Single.Parse(codestore[i+5]),Single.Parse(codestore[i+6]));
                    //	GL.Vertex3(Single.Parse(codestore[i+7]),Single.Parse(codestore[i+8]),Single.Parse(codestore[i+9]));
                }
                // 		if (codestore[i].Contains("end")){
                // 		
                //  	}

                //   GL.Translate(0.4,-0.4,dd);

                //  GL.ClearColor(0.812f,0,0,1);
                //   model("models/leg.rq3d");
            }

            glControl1.SwapBuffers();
        }

        void Button1Click(object sender, EventArgs e)
        {
            //  GL.ClearColor(Color.RoyalBlue);
            dd += 0.1;
            glControl1.Invalidate();
        }

        void GlControl1Resize(object sender, EventArgs e)
        {
            //base.OnResize();
            // GL.Viewport(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);

            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, Width / (float)Height, 1.0f, 64.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);

        }

        void Button3Click(object sender, EventArgs e)
        {

            //inputdialog.Visible = false;
            textBox1.Text += String.Format("block {0} {1} {2} color {4} {6} {5} {3} ", textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox10.Text, textBox7.Text, textBox8.Text);
            //MessageBox.Show(String.Format(" block {0} {1} {2} color {4} {6} {5} {3}",textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,textBox10.Text,textBox7.Text,textBox8.Text));
        }

        void Timer1Tick(object sender, EventArgs e)
        {
            glControl1.Invalidate();
        }

        void Button4Click(object sender, EventArgs e)
        {
            inputdialog.Visible = true;
        }

        void Button5Click(object sender, EventArgs e)
        {
            inputdialog.Visible = false;
        }

        void MainFormLoad(object sender, EventArgs e)
        {
            textBox1.ForeColor = SystemColors.Control;

        }

        void Button6Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently this feature not supported :(");
            isShine = true;
            GL.Enable(EnableCap.PolygonSmooth);
        }

        void Button10Click(object sender, EventArgs e)
        {
            DevChat DevChat = new DevChat();
            DevChat.Show();
        }

        void GlControl1MouseMove(object sender, MouseEventArgs e)
        {
            switch (rightclick)
            {
                case true:
                    rotX = e.X;
                    rotY = e.Y;
                    break;
                case false:
                    rotX = rotX;
                    rotY = rotY;
                    break;

            }


        }

        void GlControl1MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {

                case MouseButtons.Left:
                    rightclick = false;
                    break;

                case MouseButtons.Right:

                    rightclick = true;
                    break;

            }

        }

        void GlControl1MouseUp(object sender, MouseEventArgs e)
        {
            rightclick = false;
        }

        void GlControl1KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.w:
                    tra_z -= 0.1d;
                    break;
                case Keys.S:
                    tra_z += 0.1d;
                    break;
                case Keys.A:
                    tra_x -= 0.1d;
                    break;
                case Keys.D:
                    tra_x += 0.1d;
                    break;
                case Keys.E:
                    tra_y -= 0.1d;
                    break;
                case Keys.Q:
                    tra_y += 0.1d;
                    break;
            }


        }

        void CheckBox1CheckStateChanged(object sender, EventArgs e)
        {
            switch (CheckBox1.Checked)
            {
                case true:
                    isSmooth = true;
                    break;
                case false:
                    isSmooth = false;
            }
        }

        void Button12Click(object sender, EventArgs e)
        {
            panel4.Visible = true;

        }

        void Button13Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void DrawColorWheel(Graphics gr, Color outline_color, int xmin, int ymin, int wid, int hgt)
        {
            Rectangle rect = new Rectangle(xmin, ymin, wid, hgt);
            GraphicsPath wheel_path = new GraphicsPath();
            wheel_path.AddEllipse(rect);
            wheel_path.Flatten();

            int num_pts = (wheel_path.PointCount - 1) / 3;
            Color[] surround_colors = new Color[wheel_path.PointCount];
            float r = 255,
            g = 0,
            b = 0;
            float dr,
            dg,
            db;
            dr = -255 / num_pts;
            db = 255 / num_pts;
            for (int i = 0; i < num_pts; i++)
            {
                surround_colors[i] = Color.FromArgb(255, (int)r, (int)g, (int)b);
                r += dr;
                b += db;
            }

            r = 0;
            g = 0;
            b = 255;
            dg = 255 / num_pts;
            db = -255 / num_pts;
            for (int i = num_pts; i < 2 * num_pts; i++)
            {
                surround_colors[i] = Color.FromArgb(255, (int)r, (int)g, (int)b);
                g += dg;
                b += db;
            }

            r = 0;
            g = 255;
            b = 0;
            dr = 255 / (wheel_path.PointCount - 2 * num_pts);
            dg = -255 / (wheel_path.PointCount - 2 * num_pts);
            for (int i = 2 * num_pts; i < wheel_path.PointCount; i++)
            {
                surround_colors[i] = Color.FromArgb(255, (int)r, (int)g, (int)b);
                r += dr;
                g += dg;
            }

            using (PathGradientBrush path_brush = new PathGradientBrush(wheel_path))
            {
                path_brush.CenterColor = Color.White;
                path_brush.SurroundColors = surround_colors;

                gr.FillPath(path_brush, wheel_path);

                // It looks better if we outline the wheel.
                using (Pen thick_pen = new Pen(outline_color, 2))
                {
                    gr.DrawPath(thick_pen, wheel_path);
                }
            }

            //// Uncomment the following to draw the path's points.
            //for (int i = 0; i < wheel_path.PointCount; i++)
            //{
            //    gr.FillEllipse(Brushes.Black,
            //        wheel_path.PathPoints[i].X - 2,
            //        wheel_path.PathPoints[i].Y - 2,
            //        4, 4);
            //}
        }

        void Panel6Paint(object sender, PaintEventArgs e)
        {
            DrawColorWheel(e.Graphics, Color.Black, 0, 0, 100, 100);
        }

        void Button15Click(object sender, EventArgs e)
        {
            GL.Fog(FogParameter.FogMode, Convert.ToSingle(FogMode.Linear));

            GL.Fog(FogParameter.FogEnd, Single.Parse(textBox12.Text));
        }
    }
}
