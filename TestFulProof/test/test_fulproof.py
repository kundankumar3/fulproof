import allure
from conftest import Conftest


class TestDemo(Conftest):

    @allure.step("Test launch")
    def test_ful_proof(self):
        """
        # get all devices from server
        # # """

        self.driver.get("http://localhost:8090")
        title = self.driver.title
        with allure.step("Get title: " + title):
            assert title == title

        with allure.step("Assertion check"):
            assert 4 == 4


