int BinSearch(int num,int[] arr){

    int mid;
    int low = 0;
    int high = arr.Lenth-1;
    while (low<=high)
    {
        mid = (low+high)/2;
        if(arr[mid]==num) return mid;
        else if (arr[mid]<num) low=mid+1;
        else high = mid -1;
    }
    return -1;

}