int SeqSearch(int num,int[] arr){
    int i;
    for(i=0;i<arr.Lenth;i++){
        if(arr[i]==num){
            return i;
        }
    }
    return -1;
}

main(){
    int num,R;
    int[] arr = new int[10];
    R= SeqSearch(num,arr);
    if(R==-1){
        Consol.Write("Not Found");
    }
    else
    {
        Consol.Write("Founded");
    }
}


// Best mode = 1
// Avg Mode = n/2
// worst Mode = n