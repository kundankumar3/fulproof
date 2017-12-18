import allure
from conftest import Conftest


class TestDemo(Conftest):

    @allure.step("Test launch")
    def test_ful_proof(self):
        """
        # get all devices from server
        # # """

        self.driver.get('file:///C:/Jenkins/workspace/fulproof/WebClient/index.html')
        title = self.driver.title
        with allure.step("Get title: " + title):
            assert title == title

        with allure.step("Assertion check"):
            assert 4 == 4


