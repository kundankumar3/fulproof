import allure
from conftest import Conftest


class TestDemo(Conftest):

    @allure.step("check1")
    def test_get_all_devices(self):
        """
        # get all devices from server
        # # """
        self.driver.get("http://localhost:8080/job/fulproof/")
