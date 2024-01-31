using System;

class Program {
  public static void Main (string[] args) {

    int[] myArray = { 5, 12, 8, 3, 17, 6, 9, 11, 4, 19, 2, 14, 7, 10, 1, 16, 13, 18, 15, 20 };

    divideArray(myArray);

    for(int i = 0; i < myArray.Length; i++){
      Console.Write(myArray[i] + " ");
    }
    
  }

  public static void divideArray(int[] myArray){

    int length = myArray.Length;
    if (length <= 1)
      return;

    int mid = length / 2;
    int[] leftArray = new int[mid];
    int[] rightArray = new int[length - mid];
    
    for(int i = 0; i < myArray.Length; i++){
      if (i < mid){
        leftArray[i] = myArray[i];
      }
      else{
        rightArray[i-mid] = myArray[i];
      }

    }

    divideArray(leftArray);
    divideArray(rightArray);
    merge(leftArray, rightArray, myArray);
  }

  public static void merge(int[] leftArray, int[] rightArray, int[] myArray){

    int leftIndex = 0;
    int rightIndex = 0;
    int arrayIndex = 0;

    while (leftIndex < leftArray.Length && rightIndex < rightArray.Length){
      
      if (leftArray[leftIndex] < rightArray[rightIndex]){
        myArray[arrayIndex] = leftArray[leftIndex];
        leftIndex++;
        arrayIndex++;
      }else{
        myArray[arrayIndex] = rightArray[rightIndex];
        rightIndex++;
        arrayIndex++;
      }
      
    }

    while(leftIndex < leftArray.Length){
      myArray[arrayIndex] = leftArray[leftIndex];
      leftIndex++;
      arrayIndex++;
    }
    while(rightIndex < rightArray.Length){
      myArray[arrayIndex] = rightArray[rightIndex];
      rightIndex++;
      arrayIndex++;
    }
  }
}