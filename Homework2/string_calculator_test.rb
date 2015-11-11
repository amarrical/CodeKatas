require_relative "string_calculator"
require "minitest/autorun"

class TestStringCalculator < Minitest::Test
  [['empty_string', ''],
    ['nil', nil]
  ].each do | name, number |
    define_method("test_add_return_zero_when_supplied_#{name}") do
      assert_equal(0, Calculator.add(number))
    end
  end

  [['zero', '0', 0],
   ['one', '1', 1],
   ['two', '2', 2],
   ['three', '3', 3],
   ['series', '0,1,2,3,4,555', 565]
  ].each do | name, numbers, expected |
    define_method("test_add_return_number_when_supplied_#{name}") do
     assert_equal(expected, Calculator.add(numbers))
    end
  end

  [['one_two_three', '1,2,3', 6],
   ['one_newline', "3\n2", 5],
   ['newline_and_comma', "1\n2,3", 6],
   ['two_newlines', "1\n2\n3,4,5", 15]
  ].each do | name, numbers, expected |
    define_method("test_and_return_sum_when_supplied_#{name}") do
     assert_equal(expected, Calculator.add(numbers))
   end
  end

  [['zero_two', '0,2', 2],
   ['zero_two_two', '0,2,2', 4],
   ['zero_three', '0,3', 3],
   ['zero_three_two', '0,3,2', 5],
   ['zero_three_three', '0,3,3', 6],
   ['zero_three_two', '0,3,2', 5]
  ].each do | name, numbers, expected |
     define_method("test_add_return_sum_when_supplied_multiple_numbers_#{name}") do
       assert_equal(expected, Calculator.add(numbers))
     end
   end

  [['zero_three_1001', '0,3,1001', 3],
   ['zero_three_1000', '0,3,1000', 3]
  ].each do | name, numbers, expected |
    define_method("test_add_return_sum_by_ignore_more_than_thousand_#{name}") do
       assert_equal(expected, Calculator.add(numbers))
    end
  end

  [['asterisk', '//*\n1*2', 3],
   ['semicolon', '//;\n1;2', 3],
   ['semicolon_one_through_ten', '//;\n1;2;3;4;5;6;7;8;9;10', 55]
  ].each do | name, numbers, expected |
     define_method("test_add_when_given_delimiter_uses_it_with_#{name}") do
       assert_equal(expected, Calculator.add(numbers))
     end
  end

  def test_add_raises_argument_exception_when_supplied_string_does_not_meet_rule
    err = assert_raises(ArgumentError) { Calculator.add('1,-1') }
    assert_equal(
      'string contains [-1], which does not meet rule. entered number should not negative.',
      err.message)
  end
end
