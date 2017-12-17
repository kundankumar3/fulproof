import pytest
import unittest
from selenium import webdriver


class Conftest(unittest.TestCase):

    def setUp(self):
        self.driver = webdriver.Chrome()
        self.driver.implicitly_wait(10)
        self.driver.maximize_window()

    def tearDown(self):
        if self.driver is not None:
            self.driver.close()
            if self.driver is not None:
                self.driver.quit()
