class EvenFibonacciNumbers
  class << self
    def solution
      prev = 0
      n = 1
      sum = 0
      while n <= 4_000_000
        n += prev
        prev = n - prev
        sum += n if n % 2 == 0
      end
      puts sum
    end
  end
end

EvenFibonacciNumbers.solution
