import account_creator
import Entities.account

class CheckingAccountCreator(AccountCreator):
    def create(self) -> Account:
        return CheckingAccount()