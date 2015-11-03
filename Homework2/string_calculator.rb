class Calculator
  def self.add(numbers)
    if numbers == nil
      return 0
    end
    sum = 0
    numbers.split(/,\s*|\s+/).each do | value_string |
      value = value_string.to_i
      if (value < 0)
        raise ArgumentError, "string contains [#{value_string}], which does not meet rule. entered number should not negative."
      end
      if value < 1000
        sum = sum + value.to_i
      end
    end
    return sum
  end
end
