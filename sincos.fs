\ Sin and Cosin
\ table based calculation for integer numbers
\ values salced for 10K 

vocabulary sincos    sincos definitions     decimal

create sintable  \ 0...90 degree, index = degree 
0000 ,  0175 ,  0349 ,  0523 ,  0698 ,  0872 ,  
1045 ,  1219 ,  1392 ,  1564 ,  1736 ,  1908 , 
2079 ,  2250 ,  2419 ,  2588 ,  2756 ,  2924 ,  
3090 ,  3256 ,  3420 ,  3584 ,  3746 ,  3907 ,  
4067 ,  4226 ,  4384 ,  4540 ,  4695 ,  4848 ,  
5000 ,  5150 ,  5299 ,  5446 ,  5592 ,  5736 ,  
5878 ,  6018 ,  6157 ,  6293 ,  6428 ,  6561 ,  
6691 ,  6820 ,  6947 ,  7071 ,  7193 ,  7314 ,  
7431 ,  7547 ,  7660 ,  7771 ,  7880 ,  7986 ,  
8090 ,  8192 ,  8290 ,  8387 ,  8480 ,  8572 ,  
8660 ,  8746 ,  8829 ,  8910 ,  8988 ,  9063 ,  
9135 ,  9205 ,  9272 ,  9336 ,  9397 ,  9455 ,  
9511 ,  9563 ,  9613 ,  9659 ,  9703 ,  9744 , 
9781 ,  9816 ,  9848 ,  9877 ,  9903 ,  9925 ,  
9945 ,  9962 ,  9976 ,  9986 ,  9994 ,  9998 ,  
10000 , 

: sin@          cell * sintable + @ ;
: sin           ( degree -- sin )
                dup 0< >r abs
                360 mod  
                dup 180 > if 180 - true >r else false >r then 
                dup  90 > if 180 swap - then  
                sin@  
                r> if negate then 
                r> if negate then ;
: cos           90 + sin ;

( finis)
