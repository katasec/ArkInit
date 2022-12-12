# ark-init-azure
Initializes a local ark environment for the Azure cloud. For Azure, the ark cli will require:


| No | Item | Description|
|-|-|-|
|1| Setup Pulumi BackEnd| Configure OSS Pulumi with Azure Blob Storage as a backend|
|2| Setup Ark Log Storage| Configure storage account with a blob container for text based logs|
|3| Setup Ark MQ| Create and Azure Service Bus queue for message queueing|


