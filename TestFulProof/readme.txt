Home of the automated component test of the Communication Framework

Install requirements
pip install -r requirements.txt

install scoop in powershell
iex (new-object net.webclient).downloadstring('https://get.scoop.sh')

*Install allure for python reporting using scoop
scoop install allure

*Run test using allure:
py.test --alluredir ./Reports

To generate report using allure:
run 0_Report_Launcher.bat

Generate the report

To generate the report from existing Allure results you can use the following command:

$ allure generate directory-with-results/
The report will be generated to allure-report folder. You can change the destination folder using -o flag:

$ allure generate directory-with-results/ -o directory-with-report

ipaddress = parsed_json[0]['Payload'][0]['Payload']['Network']['Ipv4IpAddress']['Value'][0]