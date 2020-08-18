resourceGroupName="northwind-armtest-rg"

# create resource group
az group create --name $resourceGroupName --location "westeurope"

# validate template
az deployment group validate -g $resourceGroupName --template-file azuredeploy.json --parameters azuredeploy.parameters.json

# create resources from template
az deployment group create -g $resourceGroupName --template-file azuredeploy.json --parameters azuredeploy.parameters.json