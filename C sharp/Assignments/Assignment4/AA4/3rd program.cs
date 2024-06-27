using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace AA4
    {
        class _3rd_program
    {
        public class InsufficientBalanceException : Exception
        {
            public InsufficientBalanceException() : base("Insufficient balance. Withdrawal failed.") { }
        }



        private double balance; 

            public _3rd_program(double initialBalance)
            {
                this.balance = initialBalance;
            }

            public void Withdraw(double amount)
            {
                try
                {
                    if (amount <= 0)
                    {
                        throw new ArgumentException("Withdrawal amount must be positive.");
                    }
                    if (amount > balance)
                    {
                        throw new InsufficientBalanceException();
                    }
                    this.balance -= amount;
                    Console.WriteLine("{amount} withdrawn successfully. Remaining balance: {balance}");
                }
                catch (ArgumentException ex)
                {
                    
                    throw ex;
                }
                catch (InsufficientBalanceException ex)
                {
                    
                    throw ex;
                }
                catch (Exception ex)
                {
                    
                    throw new Exception("Withdrawal failed due to unexpected error.", ex);
                }
            }

            static void Main(string[] args)
            {
                
                _3rd_program account = new _3rd_program(1000.0);

                try
                {
                    Console.WriteLine("Enter amount to withdraw:");
                    double withdrawAmount = double.Parse(Console.ReadLine());
                    account.Withdraw(withdrawAmount);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Argument Error: {ex.Message}");
                }
                catch (InsufficientBalanceException ex)
                {
                    Console.WriteLine("Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected Error: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Program execution completed. Press Enter to continue.");
                    Console.ReadLine();
                }
            }
        }
    }







