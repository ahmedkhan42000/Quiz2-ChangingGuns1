using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prog_Fund_Matrix_1 : MonoBehaviour
{
    int[,] Array2d1 = new int[2, 2] { { 3, 4 }, { 5, 6 } };
    int[] array = new int[] {3,4};
    float[] floatArray;
    int Row,Col;    
    void Start()
    {
        
        Matrix Mat = new Matrix();
        //Mat.MatrixByArray(2,2);
        //Mat.MatrixByList(2,2);
        //Mat.Print();
        //Mat.SetElement(1,1,5);
        Mat.MatrixBy2DArray(Array2d1);
        //Mat.SetRow(1,array);
        Mat.Print();
        //Mat.SetColumn(0,array);
        //Mat.SwapRows(0, 1);
        //Mat.SwapCols(0,1);
        //Mat.AddMatrix(Array2d1);
        //Mat.SubtMatrix(Array2d1);
        //Mat.Multiply(Array2d1);
        //Mat.SetMatrix(6);
        //Mat.SetRow(1, 5);
        //Mat.Print();
        //Mat.SetCol(0,8);
        //Mat.SetDaigonal(5);
        //Mat.SetInverseDaigonal(9);
        //Mat.IsRowSame(1);
        //Debug.Log(Mat.IsRowSame(1));
        //Debug.Log(Mat.IsColSame(1));
        //Debug.Log(Mat.IsDaigonalSame());
        //Debug.Log(Mat.IsInverseDaigonalSame());
        //Debug.Log(Mat.GetRow(1));
        //FloatArray();
        //Mat.Print();
        Mat.Multiply(Array2d1);
        //Mat.Print();
        //Mat.GetElement(0,1);

    }
    public void FloatArray()
    {
        Matrix Mat = new Matrix();
        floatArray = Mat.GetRow(1);
        for (int i = 0; i < floatArray.Length; i++)
        {
            Debug.Log(floatArray[i]);
        }
    }

}
