<# you need to run this file from 'deploy' folder level or solution directory level

#>


docker images
cd ./shop.api.order/
docker build . -t order-service:0.0.1
cd..
cd ./shop.api.shipping/
docker build . -t shipping-service:0.0.1
cd..

# re tag
docker tag order-service:0.0.1 thirul/order-service:0.0.1
docker tag shipping-service:0.0.1 thirul/shipping-service:0.0.1

# push to docker
docker login
docker push thirul/order-service:0.0.1
docker push thirul/shipping-service:0.0.1

# minikube - required administrator privileges 
minikube stop
minikube start
minikube addons enable ingress

# deploy pods, services, ingress rules to kubernetes
kubectl apply -f ./kube-deployment.yml

# get operations 
kubectl get pod 
kubectl get service 

# minikube service start - any one service 
minikube service serivce-order-service

# get cluster ip 
kubectl cluster-info

#<cluster_ip>:30773/api/shipping
#<cluster_ip>:30036/api/order

