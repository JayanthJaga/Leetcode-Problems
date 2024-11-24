public class Solution {
    public void Rotate(int[][] matrix) {
        for(int i=0;i<matrix.Length;i++)
        {
            for(int j=i;j<matrix[0].Length;j++)
            {
                (matrix[i][j],matrix[j][i])=
                (matrix[j][i],matrix[i][j]);
            }
        }

        for(int i=0;i<matrix.Length;i++)
        {
            for(int j=0;j<matrix[0].Length/2;j++)
            {
                (matrix[i][j],matrix[i][matrix[0].Length-1-j])        =(matrix[i][matrix[0].Length-1-j],matrix[i][j]);
            
            }
        
        }

    }
}