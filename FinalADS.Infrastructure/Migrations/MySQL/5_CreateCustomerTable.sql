CREATE TABLE articulo (
  cliente_id int   UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  titulo VARCHAR(150) ,
  resumen VARCHAR(150) ,
  contenido VARCHAR(150)  ,
  formato VARCHAR(4)  ,
  fechaenvio  int  ,
  fechaacept  int   ,
  fechapubli  int   ,
  account_id  INT   
  ) 
