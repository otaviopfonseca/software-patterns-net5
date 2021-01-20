from abc, import ABC, abstractmethod
class AccountCreator(ABC):
    @abstractmethod
    def create(self):
        pass