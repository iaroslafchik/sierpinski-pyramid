using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_sierpinski_pyramid {
    public partial class MainApplicationInterface : Form {
        struct Vertex {
            public Vertex(float _x, float _y, float _z) {
                x = _x; y = _y; z = _z;
            }
            public float x, y, z;
        }

        List<Vertex> vertices = new List<Vertex>();
        List<List<int>> faces = new List<List<int>>();

        List<Vertex> quadrantCoefficients = new List<Vertex> {
                new Vertex(1, 1, 1),
                new Vertex(1, 1, -1),
                new Vertex(-1, 1, 1),
                new Vertex(-1, 1, -1)
            };

        public MainApplicationInterface() {
            InitializeComponent();
            Generate(this, EventArgs.Empty);
        }

        private void Generate(object sender, EventArgs e) {
            vertices = new List<Vertex> {
                new Vertex(0, 0, 0),
                new Vertex(1, 1, 1),
                new Vertex(1, 1, -1),
                new Vertex(-1, 1, 1),
                new Vertex(-1, 1, -1)
            };
            faces = new List<List<int>> {
                new List<int>() { 0, 1, 4 },
                new List<int>() { 0, 2, 1 },
                new List<int>() { 0, 3, 2 },
                new List<int>() { 0, 4, 3 },
                new List<int>() { 1, 2, 3, 4}
            };
            int goalIterations = (int)numericUpDownIterations.Value;

            for (int procIteration = 1; procIteration <= goalIterations; procIteration++) {
                float placeOffset = 1 << (procIteration - 1);
                int amountToCopy = vertices.Count;

                List<Vertex> verticesToCheck = new List<Vertex>();
                for (int i = 1; i < amountToCopy; i++) {
                    for (int j = 0; j < 4; j++) {
                        Vertex newVertex = new Vertex(
                            vertices[i].x + placeOffset * quadrantCoefficients[j].x,
                            vertices[i].y + placeOffset * quadrantCoefficients[j].y,
                            vertices[i].z + placeOffset * quadrantCoefficients[j].z);
                        if (newVertex.x == 0 || newVertex.z == 0) {
                            if (verticesToCheck.Contains(newVertex) == false) {
                                verticesToCheck.Add(newVertex);
                            }
                            else continue;
                        }
                        vertices.Add(newVertex);
                    }
                }
            }

            statusStripLabelVertices.Text = String.Format("Вершин: {0}", vertices.Count);
            numericUpDownScroll.Maximum = vertices.Count;
            PopulateTable();
        }

        private void PopulateTable() {
            dataGridViewVertices.Rows.Clear();
            int numberOfRowsToPopulate;
            if (numericUpDownScroll.Value + numericUpDownNumber.Value < vertices.Count)
                numberOfRowsToPopulate = (int)numericUpDownNumber.Value;
            else
                numberOfRowsToPopulate = vertices.Count - (int)numericUpDownScroll.Value;

            for (int i = (int)numericUpDownScroll.Value; i < (int)numericUpDownScroll.Value + numberOfRowsToPopulate; i++) {
                dataGridViewVertices.Rows.Add(i+1, vertices[i].x, vertices[i].y, vertices[i].z);
            }
        }

        private void Label_Click(object sender, EventArgs e) {

        }

        private void NumericUpDownScroll_ValueChanged(object sender, EventArgs e) {
            PopulateTable();
        }

        private void NumericUpDownNumber_ValueChanged(object sender, EventArgs e) {
            PopulateTable();
        }
    }
}
