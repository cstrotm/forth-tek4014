\ Plot turtle graphics primitives (Smiley)

include tek.fs
include graphprim.fs
include turtle.fs

: demo4  
  \ left eye
  256 768 xy!
  128 128 rectangle

  \ right eye
  640 768 xy!
  128 square

  \ node
  512 512 xy!
  -16 -16 xy+!
  32 32 filled-rectangle

  \ mouth
  128 500 xy!
  256 256 line
  768 256 line
  916 500 line ;

tek-on page
demo4
