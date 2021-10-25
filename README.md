# InterfacesInteligentes_P2

## Ejercicio 1
- Para la realización de este ejercicio, he utilzado 3 objetos los cuales han sido: un cubo, una esfera y un terreno(al cual le he hecho una pretuberancia para así simular una caída).

  ### Apartado a
  - Ambos objetos están estáticos.

  ### Apartado b
  - La esfera se mueve debido a la gravedad pero el cubo permanece estático por lo que al chocar la esfera con el cubo esta se para o cambia de dirección.

  ### Apartado c
  - Ambos objetos se mueven debido a la gravedad, pero al chocar la esfera con el cubo este se desplaza ligeramente.

  ### Apartado d
  - Ambos objetos se mueven debido a la gravedad, pero en este caso al chocar la esfera con el cubo este se desplaza notablemente.

  ### Apartado e
  - En este caso, el cubo permanece estático pero en el intento de choque con la esfera este es atravesado.

  ### Apartado f
  - Ambos objetos se mueven debido a la gavedad, pero en este caso el cubo cae verticalmente incluso traspasando el terreno.

  ### Apartado g
  - Ambos objetos se mueven debido a la gravedad, pero en este caso el cubo cae verticalmente y cuando choca con el terreno se para y cuando la esfera choca con el mismo,         este se desplaza notablemente.

## Ejercicio 2
- Para la realización de este ejercicio, he creado un nuevo script con la finalidad de mover un objeto 3D(Cubo). Los movimientos solicitados eran: izquierda, derecha, alante y atrás, lo que esto implica que estamos hablando de movimientos en el eje X(izquierda y derecha) y en el eje Z(alante y atrás).

  Para implementar estos movimientos, he utilizado la propiedad Transform del objeto 3D y un campo público para que el usuario pueda introducir la velocidad a la que quiere     mover el cubo. Además he hecho uso de la clase Input, utilizando así Input.GetAxis que es un listener que detecta cuando pulsamos el teclado para realizar un movimiento,     en este caso las teclas aswd o las flecas. A continuación, he creado un nuevo Vector3 que contiene las coordenadas correspondientes al movimiento que se desea realizar.       Para ello, debemos tener en cuenta que el eje X representa el movimiento de izquierda y derecha, el eje Y representa el movimiento hacia arriba o hacia abajo y el eje Z       representa el movimiento hacia delante o hacia atrás. También, he hecho uso de Time.deltaTime para escalar los movimientos según el tiempo transcurrido(Tiempo real) y no     por frame(Tiempo Físico).

  ### Script
    ![Script](https://github.com/EduardoEB3/InterfacesInteligentes_P2/blob/main/images/Scrip_Ejercicio2.jpg)
   
  ### GIF
    ![GIF](https://github.com/EduardoEB3/InterfacesInteligentes_P2/blob/main/GIFs/GIF_Ejercicio2.gif)
    
 ## Ejercicio 3
 
  ### Aumentar tamaño cilindro
   ![GIF](https://github.com/EduardoEB3/InterfacesInteligentes_P2/blob/main/GIFs/GIF_Ejercicio3_Punto1.gif)
   
  ### Barra espaciadora
   ![GIF](https://github.com/EduardoEB3/InterfacesInteligentes_P2/blob/main/GIFs/GIF_Ejercicio3_Punto2.gif)
  
  ### Alejar cilindros
   ![GIF](https://github.com/EduardoEB3/InterfacesInteligentes_P2/blob/main/GIFs/GIF_Ejercicio3_Punto3.gif)
   
  ### Cubo con ILJM
   ![GIF](https://github.com/EduardoEB3/InterfacesInteligentes_P2/blob/main/GIFs/GIF_Ejercicio3_Punto4.gif)
   
  ### Aumentar tamaño cubo
   - No fuí capaz de conseguirlo.

## Estructura de directorios
El directorio está organizado de la siguiente manera:
  
      .
      ├── GIF
          ├── GIF_Ejercicio2.gif
          ├── GIF_Ejercicio3_Punto1.gif
          ├── GIF_Ejercicio3_Punto2.gif
          ├── GIF_Ejercicio3_Punto3.gif
          ├── GIF_Ejercicio3_Punto4.gif
      ├── image
          ├── Script_Ejercicio2.jpg
      ├── scripts
          ├── Ejercicio2
              ├── MovimientoCubo.cs
          ├── Ejercicio3
              ├── AlejarCilindros.cs
              ├── Cilindros.cs
              ├── Controlador.cs
              ├── EspacioCilindros.cs
              ├── Jugador.cs
          
**Realizado por:** *Eduardo Expósito Barrera*

**Correo institucional:** alu0101230382@ull.edu.es

