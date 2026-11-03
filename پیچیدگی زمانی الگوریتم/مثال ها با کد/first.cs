func(int n, int[] arr){

    int i,max;
    max = arr[0];
    for(int i=1;i<arr.lenth;i++){

        if(arr[i]>max){
            max=arr[i];
        }

        consol.write(max);

    }
}

/*
حلقه که بزرگ ترین عنصر ارایه را پیدا میکند
هر بار 3 کد را اجرا میکند
اما با این تفاوت که حلقه از تعداد عناصر ارایه کمتر
*/