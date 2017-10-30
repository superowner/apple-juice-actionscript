package system 
{
	[struct]
	[link_system]
	public final class Byte extends _Object_ implements IComparable
	{
		[native, _system_Byte_MaxValue_getter]
		public static const MaxValue:Byte;
		
		[native, _system_Byte_MinValue_getter]
		public static const MinValue:Byte;
		
		[creator];
		[native, _system_Byte_creator__];
		private static function _creator(type:Class):*;
		
		[explicit_from];
		[native, _system_Byte_explicit_from_];
		private static function _explicit_from_value(v:int):*;
		
		[implicit_from];
		[native, _system_Byte_implicit_from_];
		private static function _implicit_from_value(v:int):*;
		
		[native,_system_Byte_ctor]
		public function Byte(v:int = 0);
		
		[native,_system_Byte_static_parse]
		public static function parse(v:String):Byte;
		
		[native,_system_Byte_valueOf]
		public function valueOf():Number;
		
		[native,_system_Byte_toString_]
		public function toString_(format:String):String;
		
		[native,_system_icomparable_compareto_]
		function compareTo(obj:_Object_):int;
	}

}