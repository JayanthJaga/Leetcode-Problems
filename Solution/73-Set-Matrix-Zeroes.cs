public class Solution {
    public void SetZeroes(int[][] matrix) {
        bool row=false,col=false;
        for(int i=0;i<matrix.Length;i++)
        {
            for(int j=0;j<matrix[0].Length;j++)
            {
                if(matrix[i][j]==0){
                    if(i==0){
                        row=true;
                    }
                    if(j==0){
                        col=true;
                    }
                    matrix[i][0]=0;
                    matrix[0][j]=0;
                }
            }
        }
        for(int i=1;i<matrix.Length;i++)
        {
            for(int j=1;j<matrix[0].Length;j++)
            {
                if(matrix[i][0]==0 || matrix[0][j]==0){
                    matrix[i][j]=0;
                }
            
            }
        
        }
        if(row){
            for(int i=0;i<matrix[0].Length;i++)
            {
                matrix[0][i]=0;
            
            }
        }
            if(col){
            for(int j=0;j<matrix.Length;j++)
            {
                matrix[j][0]=0;
            }
        
        }
        
    }
}