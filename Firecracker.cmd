xcopy Test1\bin\Debug\*.junit.xml Test1\Reports
java -jar practitest-firecracker-standalone.jar --api-uri=https://eu1-prod-api.practitest.app/ --reports-path="Test1\Reports" --testset-name="Test1" --author-id=26945 --config-path="C:\Users\RamyaKadali\FC.config.json" create-and-populate-testset
