```
#your currenly installed docker version
version: "4.21.1"

services:
 rabbitmq:
  image: rabbitmq:management
  container_name: rabbitmq
  ports:
   - 5672:5672
   - 15672:15672
  volumes:
   - rabbitmqdata:/var/lib/rabbitmq
  hostname: rabbitmq
  
volumes:
 rabbitmqdata:   
```