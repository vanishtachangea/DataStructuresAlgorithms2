//0,1,1,2,3,5,8,13

function fibonacci( n)
{
  if(n==0)
  return 0;
  if(n==1)
  return 1;
  return fibonacci(n-1)+fibonacci(n-2);

}

function fibonacciMemoised(n)
{
  memoized ={};
  console.log(memoized);
  return function fib(n)
  {
    if(memoized[n])
      return memoized[n];
    if(n==0)
      return 0;
    if(n==1)
      return 1;
    if(!memoized[n])
      memoized[n] = fib(n-1)+fib(n-2);
    console.log(memoized);
    return memoized[n];
  }


}


var a = fibonacciMemoised();
console.log(a(8));

//fibonacci(8);
