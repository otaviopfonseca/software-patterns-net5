import account_creator
import Entities.account

class SavingAccountCreator(AccountCreator):
    def create(self) -> Account:
        return SavingAccount()