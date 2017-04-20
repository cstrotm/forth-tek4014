\ Plot sin wave

include sincos.fs
include tek.fs
also sincos

: demo2  
  1025 0 
  DO     i i sin 100 / 500 + plot 
  LOOP  ;

tek-on page
demo2
