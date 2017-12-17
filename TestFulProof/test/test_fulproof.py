import allure
from conftest import Conftest


class TestDemo(Conftest):

    @allure.test("Test launch")
    def test_ful_proof(self):
        """
        # get all devices from server
        # # """

        self.driver.get("http://localhost:8090")
        with allure.step("Get title"):
            title = self.driver.title
            assert title == title

        with allure.step("Assertion check"):
            assert 4 == 5


