class Calculator
  @@defaultDelimiter = /,\s*|\s+/

  def self.add(numbers)
    if numbers == nil
      return 0
    end
    delimiter = determineDelimiter(numbers)
    numberArray = parseNumbers(numbers, delimiter)
    # puts "Delimiter: #{delimiter}\nOriginal String: #{numbers}\nParsed: #{numberArray}"
    return addArray(numberArray)
  end

  def self.addArray(numbersArray)
    sum = 0
    numbersArray.each do | value_string |
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

  def self.determineDelimiter(numbers)
    unless numbers.start_with?("//")
      return @@defaultDelimiter
    end
    return numbers[2..numbers.index('\n') - 1]
  end

  def self.parseNumbers(numberString, delimiter)
    parseableNumberString = numberString
    if numberString.start_with?("//")
      parseableNumberString = numberString[numberString.index('\n') + 2, numberString.length]
    end
    return parseableNumberString.split(delimiter)
  end
end
