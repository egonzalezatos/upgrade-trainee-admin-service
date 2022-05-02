#Vars
$dockerize=$args[0]
$namespace = "upgrade-trainee-admin"
$path = "devops/kubernetes"

if ($dockerize -eq $true) {
    ./devops/pipelines/dockerize.ps1
}
#kubernetes
#Create Namespace
kubectl get ns $namespace 
kubectl create ns $namespace

#Clean
kubectl --namespace=$namespace delete --all deploy
kubectl --namespace=$namespace delete --all services
kubectl --namespace=$namespace delete -f $path/db/trainee-admin-db-secrets.yml 
kubectl --namespace=$namespace delete -f $path/db/trainee-admin-db-volumes.yml 
kubectl --namespace=$namespace delete -f $path/db/trainee-admin-db-depl.yml 
kubectl --namespace=$namespace delete -f $path/service/trainee-admin-srv-depl.yml 
kubectl --namespace=$namespace delete -f $path/trainee-admin-nodeports.yml 

#Deploy
kubectl --namespace=$namespace apply -f $path/db/trainee-admin-db-secrets.yml
kubectl --namespace=$namespace apply -f $path/db/trainee-admin-db-volumes.yml
kubectl --namespace=$namespace apply -f $path/db/trainee-admin-db-depl.yml
kubectl --namespace=$namespace apply -f $path/service/trainee-admin-srv-depl.yml

#Extern NodePorts
kubectl --namespace=$namespace apply -f $path/trainee-admin-nodeports.yml