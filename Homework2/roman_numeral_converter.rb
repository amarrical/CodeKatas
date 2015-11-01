class Converter

  def arabic_to_roman(number)
    if !number.kind_of?(Fixnum) || number < 0
      return nil
    end

    result = ""
    remaining = number
    if(number == 0)
      return "nulla"
    end

    values = getValues

    values.each do |value, letter|
      while remaining >= value
        result << letter
        remaining -= value
      end
    end

    return result
  end

  def getValues
    {
      1000 => "M",
      900 => "CM",
      500 => "D", 
      400 => "CD",
      100 => "C",
      90 => "XC",
      50 => "L",
      40 => "XL",
      10 => "X",
      9 => "IX",
      5 => "V",
      4 => "IV",
      1 => "I"
    }
  end
end