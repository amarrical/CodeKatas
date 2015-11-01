require 'spec_helper'

RSpec.describe Converter do

  before :each do
    @converter = Converter.new
  end

  describe "#new" do
    it "takes zero arguments" do
      @converter.should be_an_instance_of Converter
    end
  end

  describe "#arabic_to_roman" do
    it "converts properly" do
      hash = {
        0 => "nulla",
        1 => "I",
        2 => "II",
        3 => "III",
        4 => "IV",
        5 => "V",
        6 => "VI",
        7 => "VII",
        8 => "VIII",
        9 => "IX",
        10 => "X",
        11 => "XI",
        1066 => "MLXVI",
        1989 => "MCMLXXXIX",
        1999 => "MCMXCIX",
        2015 => "MMXV",
        3999 => "MMMCMXCIX",
        399 => "CCCXCIX"
      }

    hash.each do |key, value|
      result = @converter.arabic_to_roman(key)
      expect(result).to eq value
    end
  end

    context "Exceptions" do
        it "returns nil for negative numbers" do
        result = @converter.arabic_to_roman(-1)
        expect(result).to eq nil
      end

      it "return nil for strings" do
        result = @converter.arabic_to_roman("123")
        expect(result).to eq nil
      end

      it "return nil for objects" do
        result = @converter.arabic_to_roman(Converter.new)
        expect(result).to eq nil
      end

      it "return nil for nil" do
        result = @converter.arabic_to_roman(nil)
        expect(result).to eq nil
      end
    end
  end
end