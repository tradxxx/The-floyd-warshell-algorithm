using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_34
{
    class Modulars
    {
        Random r = new Random();
        int[,] RoudMap;
        string []point ={"A","B","C","E","F","G","H","I","J"};
        int N;
        int[,] Predki;
        public void BuildRoud(int N, DataGridView dg)
        {
            this.N = N;
            RoudMap = new int[N, N];
           
            for (int i = 0; i < N; i++)
            {
                dg.Columns.Add(point[i], point[i]);
                dg.Columns[i].Width = 60;
                dg.Rows.Add();
                dg.Rows[i].HeaderCell.Value = point[i];
                dg.AutoResizeRowHeadersWidth(i, DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            }
            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i==j)
                    {
                        RoudMap[i, j] = 0;
                        dg[i, j].Style.BackColor = System.Drawing.Color.Gray;
                        dg[i, j].Value = 0;
                    }
                    else
                    {
                        RoudMap[i, j] = r.Next(1,10);
                        dg[i, j].Value = RoudMap[i, j];
                    }
                    dg[i, j].ReadOnly = true;
                    
                }
            }
        }

        public void Analiz(DataGridView dg1,DataGridView dg2, DataGridView dg3)
        {
            for (int i = 0; i < N; i++)
            {
                dg2.Columns.Add(point[i],point[i]);
                dg2.Columns[i].Width = 60;
                dg2.Rows.Add();
                dg2.Rows[i].HeaderCell.Value = point[i];
                dg2.AutoResizeRowHeadersWidth(i, DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            }

            //Инициализация кратчайших путей по умолчанию
            Predki = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i==j)
                    {
                        Predki[i, i] = 0;
                    }
                    else
                    {
                        Predki[i, j] = i+1;
                    }
                   
                }
            }

            for (int i = 0; i < N; i++)
            {
                dg3.Columns.Add(point[i],point[i]);
                dg3.Columns[i].Width = 60;
                dg3.Rows.Add();
                dg3.Rows[i].HeaderCell.Value =point[i];
                dg3.AutoResizeRowHeadersWidth(i, DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
                
            }

            /*Основной алгоритм*/
            for (int k = 0; k < N; k++)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (RoudMap[i,j]> RoudMap[i,k]+ RoudMap[k,j])
                        {
                            RoudMap[i, j] = RoudMap[i, k] + RoudMap[k, j];
                            Predki[i, j] = Predki[k, j];
                        }

                    }
                }
            }


            //Вывод данных в таблицы
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    dg2[i, j].Value = RoudMap[i, j];
                    if (i==j)
                    {
                        dg2[i, j].Style.BackColor= System.Drawing.Color.Gray;
                    }
                }
            }


            for (int i = 0; i < N; i++)
            {
                for (int g = 0; g < N; g++)
                {
                    dg3[i, g].Value = Predki[i, g]+" п.";

                    if (i==g)
                    {
                        dg3[i, g].Style.BackColor = System.Drawing.Color.Gray;
                    }
                }
            }

            //Вывод пункотов по кратчайшим путям
            //string[,] Path = new string[N, N];
            

            
        }
    }
}
