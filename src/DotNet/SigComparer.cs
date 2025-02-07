// dnlib: See LICENSE.txt for more info

using System;
using System.Collections.Generic;
using System.Reflection;

namespace dnlib.DotNet {
	/// <summary>
	/// Compares types
	/// </summary>
	public sealed class TypeEqualityComparer : IEqualityComparer<IType>, IEqualityComparer<ITypeDefOrRef>, IEqualityComparer<TypeRef>, IEqualityComparer<TypeDef>, IEqualityComparer<TypeSpec>, IEqualityComparer<TypeSig>, IEqualityComparer<ExportedType> {
		readonly SigComparerOptions options;

		/// <summary>
		/// Default instance
		/// </summary>
		public static readonly TypeEqualityComparer Instance = new TypeEqualityComparer(0);

		/// <summary>
		/// Case insensitive names
		/// </summary>
		public static readonly TypeEqualityComparer CaseInsensitive = new TypeEqualityComparer(SigComparerOptions.CaseInsensitiveAll);

		/// <summary>
		/// Compares definitions in same module using reference comparison instead of comparing them by name, signature, etc.
		/// </summary>
		public static readonly TypeEqualityComparer CompareReferenceInSameModule = new TypeEqualityComparer(SigComparerOptions.ReferenceCompareForMemberDefsInSameModule);

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="options">Comparison options</param>
		public TypeEqualityComparer(SigComparerOptions options) => this.options = options;

		/// <inheritdoc/>
		public bool Equals(IType x, IType y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(IType obj) => new SigComparer(options).GetHashCode(obj);

		/// <inheritdoc/>
		public bool Equals(ITypeDefOrRef x, ITypeDefOrRef y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(ITypeDefOrRef obj) => new SigComparer(options).GetHashCode(obj);

		/// <inheritdoc/>
		public bool Equals(TypeRef x, TypeRef y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(TypeRef obj) => new SigComparer(options).GetHashCode(obj);

		/// <inheritdoc/>
		public bool Equals(TypeDef x, TypeDef y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(TypeDef obj) => new SigComparer(options).GetHashCode(obj);

		/// <inheritdoc/>
		public bool Equals(TypeSpec x, TypeSpec y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(TypeSpec obj) => new SigComparer(options).GetHashCode(obj);

		/// <inheritdoc/>
		public bool Equals(TypeSig x, TypeSig y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(TypeSig obj) => new SigComparer(options).GetHashCode(obj);

		/// <inheritdoc/>
		public bool Equals(ExportedType x, ExportedType y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(ExportedType obj) => new SigComparer(options).GetHashCode(obj);
	}

	/// <summary>
	/// Compares fields
	/// </summary>
	public sealed class FieldEqualityComparer : IEqualityComparer<IField>, IEqualityComparer<FieldDef>, IEqualityComparer<MemberRef> {
		readonly SigComparerOptions options;

		/// <summary>
		/// Compares the declaring types
		/// </summary>
		public static readonly FieldEqualityComparer CompareDeclaringTypes = new FieldEqualityComparer(SigComparerOptions.CompareMethodFieldDeclaringType);

		/// <summary>
		/// Doesn't compare the declaring types
		/// </summary>
		public static readonly FieldEqualityComparer DontCompareDeclaringTypes = new FieldEqualityComparer(0);

		/// <summary>
		/// Compares the declaring types, case insensitive names
		/// </summary>
		public static readonly FieldEqualityComparer CaseInsensitiveCompareDeclaringTypes = new FieldEqualityComparer(SigComparerOptions.CompareMethodFieldDeclaringType | SigComparerOptions.CaseInsensitiveAll);

		/// <summary>
		/// Doesn't compare the declaring types, case insensitive names
		/// </summary>
		public static readonly FieldEqualityComparer CaseInsensitiveDontCompareDeclaringTypes = new FieldEqualityComparer(SigComparerOptions.CaseInsensitiveAll);

		/// <summary>
		/// Compares definitions in same module using reference comparison instead of comparing them by name, signature, etc.
		/// </summary>
		public static readonly FieldEqualityComparer CompareReferenceInSameModule = new FieldEqualityComparer(SigComparerOptions.ReferenceCompareForMemberDefsInSameModule);

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="options">Comparison options</param>
		public FieldEqualityComparer(SigComparerOptions options) => this.options = options;

		/// <inheritdoc/>
		public bool Equals(IField x, IField y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(IField obj) => new SigComparer(options).GetHashCode(obj);

		/// <inheritdoc/>
		public bool Equals(FieldDef x, FieldDef y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(FieldDef obj) => new SigComparer(options).GetHashCode(obj);

		/// <inheritdoc/>
		public bool Equals(MemberRef x, MemberRef y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(MemberRef obj) => new SigComparer(options).GetHashCode(obj);
	}

	/// <summary>
	/// Compares methods
	/// </summary>
	public sealed class MethodEqualityComparer : IEqualityComparer<IMethod>, IEqualityComparer<IMethodDefOrRef>, IEqualityComparer<MethodDef>, IEqualityComparer<MemberRef>, IEqualityComparer<MethodSpec> {
		readonly SigComparerOptions options;

		/// <summary>
		/// Compares the declaring types
		/// </summary>
		public static readonly MethodEqualityComparer CompareDeclaringTypes = new MethodEqualityComparer(SigComparerOptions.CompareMethodFieldDeclaringType);

		/// <summary>
		/// Doesn't compare the declaring types
		/// </summary>
		public static readonly MethodEqualityComparer DontCompareDeclaringTypes = new MethodEqualityComparer(0);

		/// <summary>
		/// Compares the declaring types, case insensitive names
		/// </summary>
		public static readonly MethodEqualityComparer CaseInsensitiveCompareDeclaringTypes = new MethodEqualityComparer(SigComparerOptions.CompareMethodFieldDeclaringType | SigComparerOptions.CaseInsensitiveAll);

		/// <summary>
		/// Doesn't compare the declaring types, case insensitive names
		/// </summary>
		public static readonly MethodEqualityComparer CaseInsensitiveDontCompareDeclaringTypes = new MethodEqualityComparer(SigComparerOptions.CaseInsensitiveAll);

		/// <summary>
		/// Compares definitions in same module using reference comparison instead of comparing them by name, signature, etc.
		/// </summary>
		public static readonly MethodEqualityComparer CompareReferenceInSameModule = new MethodEqualityComparer(SigComparerOptions.ReferenceCompareForMemberDefsInSameModule);

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="options">Comparison options</param>
		public MethodEqualityComparer(SigComparerOptions options) => this.options = options;

		/// <inheritdoc/>
		public bool Equals(IMethod x, IMethod y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(IMethod obj) => new SigComparer(options).GetHashCode(obj);

		/// <inheritdoc/>
		public bool Equals(IMethodDefOrRef x, IMethodDefOrRef y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(IMethodDefOrRef obj) => new SigComparer(options).GetHashCode(obj);

		/// <inheritdoc/>
		public bool Equals(MethodDef x, MethodDef y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(MethodDef obj) => new SigComparer(options).GetHashCode(obj);

		/// <inheritdoc/>
		public bool Equals(MemberRef x, MemberRef y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(MemberRef obj) => new SigComparer(options).GetHashCode(obj);

		/// <inheritdoc/>
		public bool Equals(MethodSpec x, MethodSpec y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(MethodSpec obj) => new SigComparer(options).GetHashCode(obj);
	}

	/// <summary>
	/// Compares properties
	/// </summary>
	public sealed class PropertyEqualityComparer : IEqualityComparer<PropertyDef> {
		readonly SigComparerOptions options;

		/// <summary>
		/// Compares the declaring types
		/// </summary>
		public static readonly PropertyEqualityComparer CompareDeclaringTypes = new PropertyEqualityComparer(SigComparerOptions.ComparePropertyDeclaringType);

		/// <summary>
		/// Doesn't compare the declaring types
		/// </summary>
		public static readonly PropertyEqualityComparer DontCompareDeclaringTypes = new PropertyEqualityComparer(0);

		/// <summary>
		/// Compares the declaring types, case insensitive names
		/// </summary>
		public static readonly PropertyEqualityComparer CaseInsensitiveCompareDeclaringTypes = new PropertyEqualityComparer(SigComparerOptions.ComparePropertyDeclaringType | SigComparerOptions.CaseInsensitiveAll);

		/// <summary>
		/// Doesn't compare the declaring types, case insensitive names
		/// </summary>
		public static readonly PropertyEqualityComparer CaseInsensitiveDontCompareDeclaringTypes = new PropertyEqualityComparer(SigComparerOptions.CaseInsensitiveAll);

		/// <summary>
		/// Compares definitions in same module using reference comparison instead of comparing them by name, signature, etc.
		/// </summary>
		public static readonly PropertyEqualityComparer CompareReferenceInSameModule = new PropertyEqualityComparer(SigComparerOptions.ReferenceCompareForMemberDefsInSameModule);

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="options">Comparison options</param>
		public PropertyEqualityComparer(SigComparerOptions options) => this.options = options;

		/// <inheritdoc/>
		public bool Equals(PropertyDef x, PropertyDef y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(PropertyDef obj) => new SigComparer(options).GetHashCode(obj);
	}

	/// <summary>
	/// Compares events
	/// </summary>
	public sealed class EventEqualityComparer : IEqualityComparer<EventDef> {
		readonly SigComparerOptions options;

		/// <summary>
		/// Compares the declaring types
		/// </summary>
		public static readonly EventEqualityComparer CompareDeclaringTypes = new EventEqualityComparer(SigComparerOptions.CompareEventDeclaringType);

		/// <summary>
		/// Doesn't compare the declaring types
		/// </summary>
		public static readonly EventEqualityComparer DontCompareDeclaringTypes = new EventEqualityComparer(0);

		/// <summary>
		/// Compares the declaring types, case insensitive names
		/// </summary>
		public static readonly EventEqualityComparer CaseInsensitiveCompareDeclaringTypes = new EventEqualityComparer(SigComparerOptions.CompareEventDeclaringType | SigComparerOptions.CaseInsensitiveAll);

		/// <summary>
		/// Doesn't compare the declaring types, case insensitive names
		/// </summary>
		public static readonly EventEqualityComparer CaseInsensitiveDontCompareDeclaringTypes = new EventEqualityComparer(SigComparerOptions.CaseInsensitiveAll);

		/// <summary>
		/// Compares definitions in same module using reference comparison instead of comparing them by name, signature, etc.
		/// </summary>
		public static readonly EventEqualityComparer CompareReferenceInSameModule = new EventEqualityComparer(SigComparerOptions.ReferenceCompareForMemberDefsInSameModule);

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="options">Comparison options</param>
		public EventEqualityComparer(SigComparerOptions options) => this.options = options;

		/// <inheritdoc/>
		public bool Equals(EventDef x, EventDef y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(EventDef obj) => new SigComparer(options).GetHashCode(obj);
	}

	/// <summary>
	/// Compares calling convention signatures
	/// </summary>
	public sealed class SignatureEqualityComparer : IEqualityComparer<CallingConventionSig>, IEqualityComparer<MethodBaseSig>, IEqualityComparer<MethodSig>, IEqualityComparer<PropertySig>, IEqualityComparer<FieldSig>, IEqualityComparer<LocalSig>, IEqualityComparer<GenericInstMethodSig> {
		readonly SigComparerOptions options;

		/// <summary>
		/// Default instance
		/// </summary>
		public static readonly SignatureEqualityComparer Instance = new SignatureEqualityComparer(0);

		/// <summary>
		/// Case insensitive names
		/// </summary>
		public static readonly SignatureEqualityComparer CaseInsensitive = new SignatureEqualityComparer(SigComparerOptions.CaseInsensitiveAll);

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="options">Comparison options</param>
		public SignatureEqualityComparer(SigComparerOptions options) => this.options = options;

		/// <inheritdoc/>
		public bool Equals(CallingConventionSig x, CallingConventionSig y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(CallingConventionSig obj) => new SigComparer(options).GetHashCode(obj);

		/// <inheritdoc/>
		public bool Equals(MethodBaseSig x, MethodBaseSig y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(MethodBaseSig obj) => new SigComparer(options).GetHashCode(obj);

		/// <inheritdoc/>
		public bool Equals(MethodSig x, MethodSig y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(MethodSig obj) => new SigComparer(options).GetHashCode(obj);

		/// <inheritdoc/>
		public bool Equals(PropertySig x, PropertySig y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(PropertySig obj) => new SigComparer(options).GetHashCode(obj);

		/// <inheritdoc/>
		public bool Equals(FieldSig x, FieldSig y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(FieldSig obj) => new SigComparer(options).GetHashCode(obj);

		/// <inheritdoc/>
		public bool Equals(LocalSig x, LocalSig y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(LocalSig obj) => new SigComparer(options).GetHashCode(obj);

		/// <inheritdoc/>
		public bool Equals(GenericInstMethodSig x, GenericInstMethodSig y) => new SigComparer(options).Equals(x, y);

		/// <inheritdoc/>
		public int GetHashCode(GenericInstMethodSig obj) => new SigComparer(options).GetHashCode(obj);
	}

	/// <summary>
	/// Decides how to compare types, sigs, etc
	/// </summary>
	[Flags]
	public enum SigComparerOptions : uint {
		/// <summary>
		/// Don't compare a type's (assembly/module) scope
		/// </summary>
		DontCompareTypeScope = 1,

		/// <summary>
		/// Compares a method/field's declaring type.
		/// </summary>
		CompareMethodFieldDeclaringType = 2,

		/// <summary>
		/// Compares a property's declaring type
		/// </summary>
		ComparePropertyDeclaringType = 4,

		/// <summary>
		/// Compares an event's declaring type
		/// </summary>
		CompareEventDeclaringType = 8,

		/// <summary>
		/// Compares method / field / property / event declaring types
		/// </summary>
		CompareDeclaringTypes = CompareMethodFieldDeclaringType | ComparePropertyDeclaringType | CompareEventDeclaringType,

		/// <summary>
		/// Compares parameters after a sentinel in method sigs. Should not be enabled when
		/// comparing <see cref="MethodSig"/>s against <see cref="MethodInfo"/>s since it's
		/// not possible to get those sentinel params from a <see cref="MethodInfo"/>.
		/// </summary>
		CompareSentinelParams = 0x10,

		/// <summary>
		/// Compares assembly public key token
		/// </summary>
		CompareAssemblyPublicKeyToken = 0x20,

		/// <summary>
		/// Compares assembly version
		/// </summary>
		CompareAssemblyVersion = 0x40,

		/// <summary>
		/// Compares assembly locale
		/// </summary>
		CompareAssemblyLocale = 0x80,

		/// <summary>
		/// If set, a <see cref="TypeRef"/> and an <see cref="ExportedType"/> can reference the
		/// global <c>&lt;Module&gt;</c> type.
		/// </summary>
		TypeRefCanReferenceGlobalType = 0x100,

		/// <summary>
		/// Don't compare a method/property's return type
		/// </summary>
		DontCompareReturnType = 0x200,

		// Internal only
		//SubstituteGenericParameters = 0x400,

		/// <summary>
		/// Type namespaces are case insensitive
		/// </summary>
		CaseInsensitiveTypeNamespaces = 0x800,

		/// <summary>
		/// Type names (not namespaces) are case insensitive
		/// </summary>
		CaseInsensitiveTypeNames = 0x1000,

		/// <summary>
		/// Type names and namespaces are case insensitive
		/// </summary>
		CaseInsensitiveTypes = CaseInsensitiveTypeNamespaces | CaseInsensitiveTypeNames,

		/// <summary>
		/// Method and field names are case insensitive
		/// </summary>
		CaseInsensitiveMethodFieldNames = 0x2000,

		/// <summary>
		/// Property names are case insensitive
		/// </summary>
		CaseInsensitivePropertyNames = 0x4000,

		/// <summary>
		/// Event names are case insensitive
		/// </summary>
		CaseInsensitiveEventNames = 0x8000,

		/// <summary>
		/// Type namespaces, type names, method names, field names, property names
		/// and event names are all case insensitive
		/// </summary>
		CaseInsensitiveAll = CaseInsensitiveTypeNamespaces | CaseInsensitiveTypeNames |
						CaseInsensitiveMethodFieldNames | CaseInsensitivePropertyNames |
						CaseInsensitiveEventNames,

		/// <summary>
		/// A field that is <see cref="FieldAttributes.PrivateScope"/> can compare equal to
		/// a <see cref="MemberRef"/>
		/// </summary>
		PrivateScopeFieldIsComparable = 0x10000,

		/// <summary>
		/// A method that is <see cref="MethodAttributes.PrivateScope"/> can compare equal to
		/// a <see cref="MemberRef"/>
		/// </summary>
		PrivateScopeMethodIsComparable = 0x20000,

		/// <summary>
		/// A field that is <see cref="FieldAttributes.PrivateScope"/> and a method that is
		/// <see cref="MethodAttributes.PrivateScope"/> can compare equal to a <see cref="MemberRef"/>
		/// </summary>
		PrivateScopeIsComparable = PrivateScopeFieldIsComparable | PrivateScopeMethodIsComparable,

		/// <summary>
		/// Raw (bit by bit) comparison of signatures. This matches what the CLR does when it
		/// compares signatures. This means that metadata tokens will be compared.
		/// </summary>
		RawSignatureCompare = 0x40000,

		/// <summary>
		/// Ignore required and optional modifiers when comparing <see cref="TypeSig"/>s.
		/// They're already ignored when comparing eg. a <see cref="TypeSig"/> with a
		/// <see cref="TypeRef"/>.
		/// </summary>
		IgnoreModifiers = 0x80000,

		/// <summary>
		/// By default, all module and assembly compares when they're both the system library
		/// (eg. mscorlib or System.Runtime.dll) return true, even if they're really different,
		/// eg. mscorlib (.NET Framework 2.0) vs mscorlib (Windows CE). If this flag is set, the system
		/// library is compared just like any other module/assembly.
		/// </summary>
		MscorlibIsNotSpecial = 0x100000,

		/// <summary>
		/// Don't project CLR compatible WinMD references back to the original CLR type/method before comparing
		/// </summary>
		DontProjectWinMDRefs = 0x200000,

		/// <summary>
		/// Don't check type equivalence when comparing types. Starting with .NET Framework 4.0, two different
		/// types can be considered equivalent if eg. a TypeIdentifierAttribute is used.
		/// </summary>
		DontCheckTypeEquivalence = 0x400000,

		/// <summary>
		/// When comparing types, don't compare a multi-dimensional array's lower bounds and sizes
		/// </summary>
		IgnoreMultiDimensionalArrayLowerBoundsAndSizes = 0x800000,

		/// <summary>
		/// When comparing MemberDefs in same module, use regular reference comparison instead
		/// comparing the signature, name, and other properties.
		/// </summary>
		ReferenceCompareForMemberDefsInSameModule = 0x1000000,
	}

	/// <summary>
	/// Compares types, signatures, methods, fields, properties, events
	/// </summary>
	public struct SigComparer {
		const SigComparerOptions SigComparerOptions_DontSubstituteGenericParameters = (SigComparerOptions)0x400;

		const int HASHCODE_MAGIC_GLOBAL_TYPE = 1654396648;
		const int HASHCODE_MAGIC_NESTED_TYPE = -1049070942;
		const int HASHCODE_MAGIC_ET_MODULE = -299744851;
		const int HASHCODE_MAGIC_ET_VALUEARRAY = -674970533;
		const int HASHCODE_MAGIC_ET_GENERICINST = -2050514639;
		const int HASHCODE_MAGIC_ET_VAR = 1288450097;
		const int HASHCODE_MAGIC_ET_MVAR = -990598495;
		const int HASHCODE_MAGIC_ET_ARRAY = -96331531;
		const int HASHCODE_MAGIC_ET_SZARRAY = 871833535;
		const int HASHCODE_MAGIC_ET_BYREF = -634749586;
		const int HASHCODE_MAGIC_ET_PTR = 1976400808;
		const int HASHCODE_MAGIC_ET_SENTINEL = 68439620;

		RecursionCounter recursionCounter;
		SigComparerOptions options;
		GenericArguments genericArguments;
		readonly ModuleDef sourceModule;

		bool DontCompareTypeScope => (options & SigComparerOptions.DontCompareTypeScope) != 0;
		bool CompareMethodFieldDeclaringType => (options & SigComparerOptions.CompareMethodFieldDeclaringType) != 0;
		bool ComparePropertyDeclaringType => (options & SigComparerOptions.ComparePropertyDeclaringType) != 0;
		bool CompareEventDeclaringType => (options & SigComparerOptions.CompareEventDeclaringType) != 0;
		bool CompareSentinelParams => (options & SigComparerOptions.CompareSentinelParams) != 0;
		bool CompareAssemblyPublicKeyToken => (options & SigComparerOptions.CompareAssemblyPublicKeyToken) != 0;
		bool CompareAssemblyVersion => (options & SigComparerOptions.CompareAssemblyVersion) != 0;
		bool CompareAssemblyLocale => (options & SigComparerOptions.CompareAssemblyLocale) != 0;
		bool TypeRefCanReferenceGlobalType => (options & SigComparerOptions.TypeRefCanReferenceGlobalType) != 0;
		bool DontCompareReturnType => (options & SigComparerOptions.DontCompareReturnType) != 0;
		bool DontSubstituteGenericParameters => (options & SigComparerOptions_DontSubstituteGenericParameters) != 0;
		bool CaseInsensitiveTypeNamespaces => (options & SigComparerOptions.CaseInsensitiveTypeNamespaces) != 0;
		bool CaseInsensitiveTypeNames => (options & SigComparerOptions.CaseInsensitiveTypeNames) != 0;
		bool CaseInsensitiveMethodFieldNames => (options & SigComparerOptions.CaseInsensitiveMethodFieldNames) != 0;
		bool CaseInsensitivePropertyNames => (options & SigComparerOptions.CaseInsensitivePropertyNames) != 0;
		bool CaseInsensitiveEventNames => (options & SigComparerOptions.CaseInsensitiveEventNames) != 0;
		bool PrivateScopeFieldIsComparable => (options & SigComparerOptions.PrivateScopeFieldIsComparable) != 0;
		bool PrivateScopeMethodIsComparable => (options & SigComparerOptions.PrivateScopeMethodIsComparable) != 0;
		bool RawSignatureCompare => (options & SigComparerOptions.RawSignatureCompare) != 0;
		bool IgnoreModifiers => (options & SigComparerOptions.IgnoreModifiers) != 0;
		bool MscorlibIsNotSpecial => (options & SigComparerOptions.MscorlibIsNotSpecial) != 0;
		bool DontProjectWinMDRefs => (options & SigComparerOptions.DontProjectWinMDRefs) != 0;
		bool DontCheckTypeEquivalence => (options & SigComparerOptions.DontCheckTypeEquivalence) != 0;
		bool IgnoreMultiDimensionalArrayLowerBoundsAndSizes => (options & SigComparerOptions.IgnoreMultiDimensionalArrayLowerBoundsAndSizes) != 0;
		bool ReferenceCompareForMemberDefsInSameModule => (options & SigComparerOptions.ReferenceCompareForMemberDefsInSameModule) != 0;

		public SigComparer() {
			CompareMethodParams = true;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="options">Comparison options</param>
		public SigComparer(SigComparerOptions options)
			: this(options, null) {
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="options">Comparison options</param>
		/// <param name="sourceModule">The module which the comparison take place in.</param>
		public SigComparer(SigComparerOptions options, ModuleDef sourceModule) {
			recursionCounter = new RecursionCounter();
			this.options = options;
			genericArguments = null;
			this.sourceModule = sourceModule;
			CompareMethodParams = true;
		}

		public bool CompareMethodParams { get; set; }

		/// <summary>
		/// <see cref="ElementType.FnPtr"/> is mapped to <see cref="System.IntPtr"/>, so use
		/// the same hash code for both
		/// </summary>
		int GetHashCode_FnPtr_SystemIntPtr() {
			// ********************************************
			// IMPORTANT: This must match GetHashCode(TYPE)
			// ********************************************

			return GetHashCode_TypeNamespace("System") +
					GetHashCode_TypeName("IntPtr");
		}

		bool Equals_Names(bool caseInsensitive, UTF8String a, UTF8String b) {
			if (caseInsensitive)
				return UTF8String.ToSystemStringOrEmpty(a).Equals(UTF8String.ToSystemStringOrEmpty(b), StringComparison.OrdinalIgnoreCase);
			return UTF8String.Equals(a, b);
		}

		bool Equals_Names(bool caseInsensitive, string a, string b) {
			if (caseInsensitive)
				return (a ?? string.Empty).Equals(b ?? string.Empty, StringComparison.OrdinalIgnoreCase);
			return (a ?? string.Empty) == (b ?? string.Empty);
		}

		int GetHashCode_Name(bool caseInsensitive, string a) {
			if (caseInsensitive)
				return (a ?? string.Empty).ToUpperInvariant().GetHashCode();
			return (a ?? string.Empty).GetHashCode();
		}

		bool Equals_TypeNamespaces(UTF8String a, UTF8String b) => Equals_Names(CaseInsensitiveTypeNamespaces, a, b);
		bool Equals_TypeNamespaces(UTF8String a, string b) => Equals_Names(CaseInsensitiveTypeNamespaces, UTF8String.ToSystemStringOrEmpty(a), b);
		int GetHashCode_TypeNamespace(UTF8String a) => GetHashCode_Name(CaseInsensitiveTypeNamespaces, UTF8String.ToSystemStringOrEmpty(a));
		int GetHashCode_TypeNamespace(string a) => GetHashCode_Name(CaseInsensitiveTypeNamespaces, a);
		bool Equals_TypeNames(UTF8String a, UTF8String b) => Equals_Names(CaseInsensitiveTypeNames, a, b);
		bool Equals_TypeNames(UTF8String a, string b) => Equals_Names(CaseInsensitiveTypeNames, UTF8String.ToSystemStringOrEmpty(a), b);
		int GetHashCode_TypeName(UTF8String a) => GetHashCode_Name(CaseInsensitiveTypeNames, UTF8String.ToSystemStringOrEmpty(a));
		int GetHashCode_TypeName(string a) => GetHashCode_Name(CaseInsensitiveTypeNames, a);
		bool Equals_MethodFieldNames(UTF8String a, UTF8String b) => Equals_Names(CaseInsensitiveMethodFieldNames, a, b);
		bool Equals_MethodFieldNames(UTF8String a, string b) => Equals_Names(CaseInsensitiveMethodFieldNames, UTF8String.ToSystemStringOrEmpty(a), b);
		int GetHashCode_MethodFieldName(UTF8String a) => GetHashCode_Name(CaseInsensitiveMethodFieldNames, UTF8String.ToSystemStringOrEmpty(a));
		int GetHashCode_MethodFieldName(string a) => GetHashCode_Name(CaseInsensitiveMethodFieldNames, a);
		bool Equals_PropertyNames(UTF8String a, UTF8String b) => Equals_Names(CaseInsensitivePropertyNames, a, b);
		bool Equals_PropertyNames(UTF8String a, string b) => Equals_Names(CaseInsensitivePropertyNames, UTF8String.ToSystemStringOrEmpty(a), b);
		int GetHashCode_PropertyName(UTF8String a) => GetHashCode_Name(CaseInsensitivePropertyNames, UTF8String.ToSystemStringOrEmpty(a));
		int GetHashCode_PropertyName(string a) => GetHashCode_Name(CaseInsensitivePropertyNames, a);
		bool Equals_EventNames(UTF8String a, UTF8String b) => Equals_Names(CaseInsensitiveEventNames, a, b);
		bool Equals_EventNames(UTF8String a, string b) => Equals_Names(CaseInsensitiveEventNames, UTF8String.ToSystemStringOrEmpty(a), b);
		int GetHashCode_EventName(UTF8String a) => GetHashCode_Name(CaseInsensitiveEventNames, UTF8String.ToSystemStringOrEmpty(a));
		int GetHashCode_EventName(string a) => GetHashCode_Name(CaseInsensitiveEventNames, a);

		SigComparerOptions ClearOptions(SigComparerOptions flags) {
			var old = options;
			options &= ~flags;
			return old;
		}

		SigComparerOptions SetOptions(SigComparerOptions flags) {
			var old = options;
			options |= flags;
			return old;
		}

		void RestoreOptions(SigComparerOptions oldFlags) => options = oldFlags;

		void InitializeGenericArguments() {
			if (genericArguments is null)
				genericArguments = new GenericArguments();
		}

		static GenericInstSig GetGenericInstanceType(IMemberRefParent parent) {
			var ts = parent as TypeSpec;
			if (ts is null)
				return null;
			return ts.TypeSig.RemoveModifiers() as GenericInstSig;
		}

		bool Equals(IAssembly aAsm, IAssembly bAsm, TypeRef b) {
			if (Equals(aAsm, bAsm))
				return true;

			// Could be an exported type. Resolve it and check again.

			var td = b.Resolve(sourceModule);
			return td is not null && Equals(aAsm, td.Module.Assembly);
		}

		bool Equals(IAssembly aAsm, IAssembly bAsm, ExportedType b) {
			if (Equals(aAsm, bAsm))
				return true;

			var td = b.Resolve();
			return td is not null && Equals(aAsm, td.Module.Assembly);
		}

		bool Equals(IAssembly aAsm, TypeRef a, IAssembly bAsm, TypeRef b) {
			if (Equals(aAsm, bAsm))
				return true;

			// Could be exported types. Resolve them and check again.

			var tda = a.Resolve(sourceModule);
			var tdb = b.Resolve(sourceModule);
			return tda is not null && tdb is not null && Equals(tda.Module.Assembly, tdb.Module.Assembly);
		}

		bool Equals(IAssembly aAsm, ExportedType a, IAssembly bAsm, ExportedType b) {
			if (Equals(aAsm, bAsm))
				return true;

			var tda = a.Resolve();
			var tdb = b.Resolve();
			return tda is not null && tdb is not null && Equals(tda.Module.Assembly, tdb.Module.Assembly);
		}

		bool Equals(IAssembly aAsm, TypeRef a, IAssembly bAsm, ExportedType b) {
			if (Equals(aAsm, bAsm))
				return true;

			// Could be an exported type. Resolve it and check again.

			var tda = a.Resolve(sourceModule);
			var tdb = b.Resolve();
			return tda is not null && tdb is not null && Equals(tda.Module.Assembly, tdb.Module.Assembly);
		}

		bool Equals(TypeDef a, IModule bMod, TypeRef b) {
			if (Equals(a.Module, bMod) && Equals(a.DefinitionAssembly, b.DefinitionAssembly))
				return true;

			// Could be an exported type. Resolve it and check again.

			var td = b.Resolve(sourceModule);
			if (td is null)
				return false;
			if (!DontCheckTypeEquivalence) {
				if (TIAHelper.Equivalent(a, td))
					return true;
			}
			return Equals(a.Module, td.Module) && Equals(a.DefinitionAssembly, td.DefinitionAssembly);
		}

		bool Equals(TypeDef a, FileDef bFile, ExportedType b) {
			if (Equals(a.Module, bFile) && Equals(a.DefinitionAssembly, b.DefinitionAssembly))
				return true;

			var td = b.Resolve();
			return td is not null && Equals(a.Module, td.Module) && Equals(a.DefinitionAssembly, td.DefinitionAssembly);
		}

		bool TypeDefScopeEquals(TypeDef a, TypeDef b) {
			if (a is null || b is null)
				return false;
			if (!DontCheckTypeEquivalence) {
				if (TIAHelper.Equivalent(a, b))
					return true;
			}
			return Equals(a.Module, b.Module);
		}

		bool Equals(TypeRef a, IModule ma, TypeRef b, IModule mb) {
			if (Equals(ma, mb) && Equals(a.DefinitionAssembly, b.DefinitionAssembly))
				return true;

			// Could be exported types. Resolve them and check again.

			var tda = a.Resolve(sourceModule);
			var tdb = b.Resolve(sourceModule);
			return tda is not null && tdb is not null &&
				Equals(tda.Module, tdb.Module) && Equals(tda.DefinitionAssembly, tdb.DefinitionAssembly);
		}

		bool Equals(TypeRef a, IModule ma, ExportedType b, FileDef fb) {
			if (Equals(ma, fb) && Equals(a.DefinitionAssembly, b.DefinitionAssembly))
				return true;

			// Could be an exported type. Resolve it and check again.

			var tda = a.Resolve(sourceModule);
			var tdb = b.Resolve();
			return tda is not null && tdb is not null &&
				Equals(tda.Module, tdb.Module) && Equals(tda.DefinitionAssembly, tdb.DefinitionAssembly);
		}

		bool Equals(Assembly aAsm, IAssembly bAsm, TypeRef b) {
			if (Equals(bAsm, aAsm))
				return true;

			// Could be an exported type. Resolve it and check again.

			var td = b.Resolve(sourceModule);
			return td is not null && Equals(td.Module.Assembly, aAsm);
		}

		bool Equals(Assembly aAsm, IAssembly bAsm, ExportedType b) {
			if (Equals(bAsm, aAsm))
				return true;

			var td = b.Resolve();
			return td is not null && Equals(td.Module.Assembly, aAsm);
		}

		bool Equals(Type a, IModule bMod, TypeRef b) {
			if (Equals(bMod, a.Module) && Equals(b.DefinitionAssembly, a.Assembly))
				return true;

			// Could be an exported type. Resolve it and check again.

			var td = b.Resolve(sourceModule);
			return td is not null && Equals(td.Module, a.Module) && Equals(td.DefinitionAssembly, a.Assembly);
		}

		bool Equals(Type a, FileDef bFile, ExportedType b) {
			if (Equals(bFile, a.Module) && Equals(b.DefinitionAssembly, a.Assembly))
				return true;

			var td = b.Resolve();
			return td is not null && Equals(td.Module, a.Module) && Equals(td.DefinitionAssembly, a.Assembly);
		}

		/// <summary>
		/// Compare members
		/// </summary>
		/// <param name="a">Member #1</param>
		/// <param name="b">Member #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(IMemberRef a, IMemberRef b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;
			IType ta, tb;
			IField fa, fb;
			IMethod ma, mb;
			PropertyDef pa, pb;
			EventDef ea, eb;

			if ((ta = a as IType) is not null && (tb = b as IType) is not null)
				result = Equals(ta, tb);
			else if ((fa = a as IField) is not null && (fb = b as IField) is not null && fa.IsField && fb.IsField)
				result = Equals(fa, fb);
			else if ((ma = a as IMethod) is not null && (mb = b as IMethod) is not null)
				result = Equals(ma, mb);
			else if ((pa = a as PropertyDef) is not null && (pb = b as PropertyDef) is not null)
				result = Equals(pa, pb);
			else if ((ea = a as EventDef) is not null && (eb = b as EventDef) is not null)
				result = Equals(ea, eb);
			else
				result = false;

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a member
		/// </summary>
		/// <param name="a">The member</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(IMemberRef a) {
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;

			int result;
			IType ta;
			IField fa;
			IMethod ma;
			PropertyDef pa;
			EventDef ea;

			if ((ta = a as IType) is not null)
				result = GetHashCode(ta);
			else if ((fa = a as IField) is not null)
				result = GetHashCode(fa);
			else if ((ma = a as IMethod) is not null)
				result = GetHashCode(ma);
			else if ((pa = a as PropertyDef) is not null)
				result = GetHashCode(pa);
			else if ((ea = a as EventDef) is not null)
				result = GetHashCode(ea);
			else
				result = 0;     // Should never be reached

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(ITypeDefOrRef a, ITypeDefOrRef b) => Equals((IType)a, (IType)b);

		/// <summary>
		/// Gets the hash code of a type
		/// </summary>
		/// <param name="a">The type</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(ITypeDefOrRef a) => GetHashCode((IType)a);

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(IType a, IType b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;
			TypeDef tda, tdb;
			TypeRef tra, trb;
			TypeSpec tsa, tsb;
			TypeSig sa, sb;
			ExportedType eta, etb;

			if ((tda = a as TypeDef) is not null & (tdb = b as TypeDef) is not null)
				result = Equals(tda, tdb);
			else if ((tra = a as TypeRef) is not null & (trb = b as TypeRef) is not null)
				result = Equals(tra, trb);
			else if ((tsa = a as TypeSpec) is not null & (tsb = b as TypeSpec) is not null)
				result = Equals(tsa, tsb);
			else if ((sa = a as TypeSig) is not null & (sb = b as TypeSig) is not null)
				result = Equals(sa, sb);
			else if ((eta = a as ExportedType) is not null & (etb = b as ExportedType) is not null)
				result = Equals(eta, etb);
			else if (tda is not null && trb is not null)
				result = Equals(tda, trb);      // TypeDef vs TypeRef
			else if (tra is not null && tdb is not null)
				result = Equals(tdb, tra);      // TypeDef vs TypeRef
			else if (tda is not null && tsb is not null)
				result = Equals(tda, tsb);      // TypeDef vs TypeSpec
			else if (tsa is not null && tdb is not null)
				result = Equals(tdb, tsa);      // TypeDef vs TypeSpec
			else if (tda is not null && sb is not null)
				result = Equals(tda, sb);       // TypeDef vs TypeSig
			else if (sa is not null && tdb is not null)
				result = Equals(tdb, sa);       // TypeDef vs TypeSig
			else if (tda is not null && etb is not null)
				result = Equals(tda, etb);      // TypeDef vs ExportedType
			else if (eta is not null && tdb is not null)
				result = Equals(tdb, eta);      // TypeDef vs ExportedType
			else if (tra is not null && tsb is not null)
				result = Equals(tra, tsb);      // TypeRef vs TypeSpec
			else if (tsa is not null && trb is not null)
				result = Equals(trb, tsa);      // TypeRef vs TypeSpec
			else if (tra is not null && sb is not null)
				result = Equals(tra, sb);       // TypeRef vs TypeSig
			else if (sa is not null && trb is not null)
				result = Equals(trb, sa);       // TypeRef vs TypeSig
			else if (tra is not null && etb is not null)
				result = Equals(tra, etb);      // TypeRef vs ExportedType
			else if (eta is not null && trb is not null)
				result = Equals(trb, eta);      // TypeRef vs ExportedType
			else if (tsa is not null && sb is not null)
				result = Equals(tsa, sb);       // TypeSpec vs TypeSig
			else if (sa is not null && tsb is not null)
				result = Equals(tsb, sa);       // TypeSpec vs TypeSig
			else if (tsa is not null && etb is not null)
				result = Equals(tsa, etb);      // TypeSpec vs ExportedType
			else if (eta is not null && tsb is not null)
				result = Equals(tsb, eta);      // TypeSpec vs ExportedType
			else if (sa is not null && etb is not null)
				result = Equals(sa, etb);       // TypeSig vs ExportedType
			else if (eta is not null && sb is not null)
				result = Equals(sb, eta);       // TypeSig vs ExportedType
			else
				result = false; // Should never be reached

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a type
		/// </summary>
		/// <param name="a">The type</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(IType a) {
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;

			int hash;
			TypeDef td;
			TypeRef tr;
			TypeSpec ts;
			TypeSig sig;
			ExportedType et;

			if ((td = a as TypeDef) is not null)
				hash = GetHashCode(td);
			else if ((tr = a as TypeRef) is not null)
				hash = GetHashCode(tr);
			else if ((ts = a as TypeSpec) is not null)
				hash = GetHashCode(ts);
			else if ((sig = a as TypeSig) is not null)
				hash = GetHashCode(sig);
			else if ((et = a as ExportedType) is not null)
				hash = GetHashCode(et);
			else
				hash = 0;   // Should never be reached

			recursionCounter.Decrement();
			return hash;
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeRef a, TypeDef b) => Equals(b, a);

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeDef a, TypeRef b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;
			IModule bMod;
			AssemblyRef bAsm;
			TypeRef dtb;

			if (!DontProjectWinMDRefs) {
				var tra = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a);
				b = WinMDHelpers.ToCLR(b.Module ?? sourceModule, b) ?? b;
				if (tra is not null) {
					result = Equals(tra, b);
					goto exit;
				}
			}

			var scope = b.ResolutionScope;

			if (!Equals_TypeNames(a.Name, b.Name) || !Equals_TypeNamespaces(a.Namespace, b.Namespace))
				result = false;
			else if ((dtb = scope as TypeRef) is not null)  // nested type
				result = Equals(a.DeclaringType, dtb);  // Compare enclosing types
			else if (a.DeclaringType is not null) {
				// a is nested, b isn't
				result = false;
			}
			else if (DontCompareTypeScope)
				result = true;
			else if ((bMod = scope as IModule) is not null) // 'b' is defined in the same assembly as 'a'
				result = Equals(a, bMod, b);
			else if ((bAsm = scope as AssemblyRef) is not null) {
				var aMod = a.Module;
				result = aMod is not null && Equals(aMod.Assembly, bAsm, b);
				if (!result) {
					if (!DontCheckTypeEquivalence) {
						var tdb = b.Resolve();
						result = TypeDefScopeEquals(a, tdb);
					}
				}
			}
			else {
				result = false;
				//TODO: Handle the case where scope is null
			}

			if (result && !TypeRefCanReferenceGlobalType && a.IsGlobalModuleType)
				result = false;
exit:;
			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(ExportedType a, TypeDef b) => Equals(b, a);

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeDef a, ExportedType b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;
			ExportedType dtb;
			FileDef bFile;
			AssemblyRef bAsm;
			if (!DontProjectWinMDRefs) {
				var tra = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a);
				b = WinMDHelpers.ToCLR(b.Module ?? sourceModule, b) ?? b;
				if (tra is not null) {
					result = Equals(tra, b);
					goto exit;
				}
			}

			var scope = b.Implementation;

			if (!Equals_TypeNames(a.Name, b.TypeName) || !Equals_TypeNamespaces(a.Namespace, b.TypeNamespace))
				result = false;
			else if ((dtb = scope as ExportedType) is not null) {   // nested type
				result = Equals(a.DeclaringType, dtb);  // Compare enclosing types
			}
			else if (a.DeclaringType is not null) {
				result = false; // a is nested, b isn't
			}
			else if (DontCompareTypeScope)
				result = true;
			else {
				if ((bFile = scope as FileDef) is not null)
					result = Equals(a, bFile, b);
				else if ((bAsm = scope as AssemblyRef) is not null) {
					var aMod = a.Module;
					result = aMod is not null && Equals(aMod.Assembly, bAsm, b);
				}
				else
					result = false;
				if (!result && !DontCheckTypeEquivalence) {
					var tdb = b.Resolve();
					result = TypeDefScopeEquals(a, tdb);
				}
			}

			if (result && !TypeRefCanReferenceGlobalType && a.IsGlobalModuleType)
				result = false;
exit:;
			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeSpec a, TypeDef b) => Equals(b, a);

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeDef a, TypeSpec b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			return Equals(a, b.TypeSig);
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeSig a, TypeDef b) => Equals(b, a);

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeDef a, TypeSig b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;
			bool result;

			//*************************************************************
			// If this code gets updated, update GetHashCode(TypeSig),
			// Equals(TypeRef,TypeSig) and Equals(TypeSig,ExportedType) too
			//*************************************************************
			if (b is TypeDefOrRefSig b2)
				result = Equals(a, (IType)b2.TypeDefOrRef);
			else if (b is ModifierSig || b is PinnedSig)
				result = Equals(a, b.Next);
			else
				result = false;

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeSpec a, TypeRef b) => Equals(b, a);

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeRef a, TypeSpec b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			return Equals(a, b.TypeSig);
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(ExportedType a, TypeRef b) => Equals(b, a);

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeRef a, ExportedType b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			if (!DontProjectWinMDRefs) {
				a = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a) ?? a;
				b = WinMDHelpers.ToCLR(b.Module ?? sourceModule, b) ?? b;
			}
			bool result = Equals_TypeNames(a.Name, b.TypeName) &&
					Equals_TypeNamespaces(a.Namespace, b.TypeNamespace) &&
					EqualsScope(a, b);

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeSig a, TypeRef b) => Equals(b, a);

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeRef a, TypeSig b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;
			bool result;

			//*************************************************************
			// If this code gets updated, update GetHashCode(TypeSig),
			// Equals(TypeRef,TypeSig) and Equals(TypeSig,ExportedType) too
			//*************************************************************
			if (b is TypeDefOrRefSig b2)
				result = Equals(a, (IType)b2.TypeDefOrRef);
			else if (b is ModifierSig || b is PinnedSig)
				result = Equals(a, b.Next);
			else
				result = false;

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeSig a, TypeSpec b) => Equals(b, a);

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeSpec a, TypeSig b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			return Equals(a.TypeSig, b);
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(ExportedType a, TypeSpec b) => Equals(b, a);

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeSpec a, ExportedType b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			return Equals(a.TypeSig, b);
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(ExportedType a, TypeSig b) => Equals(b, a);

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeSig a, ExportedType b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;
			bool result;

			//*************************************************************
			// If this code gets updated, update GetHashCode(TypeSig),
			// Equals(TypeRef,TypeSig) and Equals(TypeSig,ExportedType) too
			//*************************************************************
			if (a is TypeDefOrRefSig a2)
				result = Equals(a2.TypeDefOrRef, b);
			else if (a is ModifierSig || a is PinnedSig)
				result = Equals(a.Next, b);
			else
				result = false;

			recursionCounter.Decrement();
			return result;
		}

		int GetHashCodeGlobalType() {
			// We don't always know the name+namespace of the global type, eg. when it's
			// referenced by a ModuleRef. Use the same hash for all global types.
			return HASHCODE_MAGIC_GLOBAL_TYPE;
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeRef a, TypeRef b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			if (!DontProjectWinMDRefs) {
				a = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a) ?? a;
				b = WinMDHelpers.ToCLR(b.Module ?? sourceModule, b) ?? b;
			}
			bool result = Equals_TypeNames(a.Name, b.Name) &&
					Equals_TypeNamespaces(a.Namespace, b.Namespace) &&
					EqualsResolutionScope(a, b);

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a type
		/// </summary>
		/// <param name="a">The type</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(TypeRef a) {
			// ************************************************************************************
			// IMPORTANT: This hash code must match the Type/TypeRef/TypeDef/ExportedType
			// hash code and GetHashCode_FnPtr_SystemIntPtr() method
			// ************************************************************************************

			// See GetHashCode(Type) for the reason why null returns GetHashCodeGlobalType()
			if (a is null)
				return TypeRefCanReferenceGlobalType ? GetHashCodeGlobalType() : 0;
			if (!DontProjectWinMDRefs)
				a = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a) ?? a;

			int hash;
			hash = GetHashCode_TypeName(a.Name);
			if (a.ResolutionScope is TypeRef)
				hash += HASHCODE_MAGIC_NESTED_TYPE;
			else
				hash += GetHashCode_TypeNamespace(a.Namespace);
			return hash;
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(ExportedType a, ExportedType b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			if (!DontProjectWinMDRefs) {
				a = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a) ?? a;
				b = WinMDHelpers.ToCLR(b.Module ?? sourceModule, b) ?? b;
			}
			bool result = Equals_TypeNames(a.TypeName, b.TypeName) &&
					Equals_TypeNamespaces(a.TypeNamespace, b.TypeNamespace) &&
					EqualsImplementation(a, b);

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a type
		/// </summary>
		/// <param name="a">The type</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(ExportedType a) {
			// ************************************************************************************
			// IMPORTANT: This hash code must match the Type/TypeRef/TypeDef/ExportedType
			// hash code and GetHashCode_FnPtr_SystemIntPtr() method
			// ************************************************************************************

			// See GetHashCode(Type) for the reason why null returns GetHashCodeGlobalType()
			if (a is null)
				return TypeRefCanReferenceGlobalType ? GetHashCodeGlobalType() : 0;
			if (!DontProjectWinMDRefs)
				a = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a) ?? a;
			int hash;
			hash = GetHashCode_TypeName(a.TypeName);
			if (a.Implementation is ExportedType)
				hash += HASHCODE_MAGIC_NESTED_TYPE;
			else
				hash += GetHashCode_TypeNamespace(a.TypeNamespace);
			return hash;
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeDef a, TypeDef b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (ReferenceCompareForMemberDefsInSameModule && InSameModule(a, b))
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;

			if (!DontProjectWinMDRefs) {
				var tra = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a);
				var trb = WinMDHelpers.ToCLR(b.Module ?? sourceModule, b);
				if (tra is not null || trb is not null) {
					result = Equals((IType)tra ?? a, (IType)trb ?? b);
					goto exit;
				}
			}
			result = Equals_TypeNames(a.Name, b.Name) &&
					Equals_TypeNamespaces(a.Namespace, b.Namespace) &&
					Equals(a.DeclaringType, b.DeclaringType) &&
					(DontCompareTypeScope || TypeDefScopeEquals(a, b));

exit:;
			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a type
		/// </summary>
		/// <param name="a">The type</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(TypeDef a) {
			// ************************************************************************************
			// IMPORTANT: This hash code must match the Type/TypeRef/TypeDef/ExportedType
			// hash code and GetHashCode_FnPtr_SystemIntPtr() method
			// ************************************************************************************

			// See GetHashCode(Type) for the reason why null returns GetHashCodeGlobalType()
			if (a is null || a.IsGlobalModuleType)
				return GetHashCodeGlobalType();
			if (!DontProjectWinMDRefs) {
				var tra = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a);
				if (tra is not null)
					return GetHashCode(tra);
			}

			int hash;
			hash = GetHashCode_TypeName(a.Name);
			if (a.DeclaringType is not null)
				hash += HASHCODE_MAGIC_NESTED_TYPE;
			else
				hash += GetHashCode_TypeNamespace(a.Namespace);
			return hash;
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeSpec a, TypeSpec b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result = Equals(a.TypeSig, b.TypeSig);

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a type
		/// </summary>
		/// <param name="a">The type</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(TypeSpec a) {
			if (a is null)
				return 0;
			return GetHashCode(a.TypeSig);
		}

		/// <summary>
		/// Compares resolution scopes
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		bool EqualsResolutionScope(TypeRef a, TypeRef b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			var ra = a.ResolutionScope;
			var rb = b.ResolutionScope;
			if (ra == rb)
				return true;
			if (ra is null || rb is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;
			TypeRef ea, eb;
			IModule ma, mb;
			AssemblyRef aa, ab;
			ModuleDef modDef;
			bool resolveCheck = true;

			// if one of them is a TypeRef, the other one must be too
			if ((ea = ra as TypeRef) is not null | (eb = rb as TypeRef) is not null) {
				result = Equals(ea, eb);
				resolveCheck = false;
			}
			else if (DontCompareTypeScope)
				result = true;
			// only compare if both are modules
			else if ((ma = ra as IModule) is not null & (mb = rb as IModule) is not null)
				result = Equals(a, ma, b, mb);
			// only compare if both are assemblies
			else if ((aa = ra as AssemblyRef) is not null & (ab = rb as AssemblyRef) is not null)
				result = Equals(aa, a, ab, b);
			else if (aa is not null && rb is ModuleRef) {
				var bMod = b.Module;
				result = bMod is not null && Equals(bMod.Assembly, b, aa, a);
			}
			else if (ab is not null && ra is ModuleRef) {
				var aMod = a.Module;
				result = aMod is not null && Equals(aMod.Assembly, a, ab, b);
			}
			else if (aa is not null && (modDef = rb as ModuleDef) is not null)
				result = Equals(modDef.Assembly, aa, a);
			else if (ab is not null && (modDef = ra as ModuleDef) is not null)
				result = Equals(modDef.Assembly, ab, b);
			else {
				result = false;
				resolveCheck = false;
			}
			if (!result && resolveCheck) {
				if (!DontCheckTypeEquivalence) {
					var td1 = a.Resolve();
					var td2 = b.Resolve();
					if (td1 is not null && td2 is not null)
						result = TypeDefScopeEquals(td1, td2);
				}
			}

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares implementation
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		bool EqualsImplementation(ExportedType a, ExportedType b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			var ia = a.Implementation;
			var ib = b.Implementation;
			if (ia == ib)
				return true;
			if (ia is null || ib is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;
			ExportedType ea, eb;
			FileDef fa, fb;
			AssemblyRef aa, ab;
			bool checkResolve = true;

			// if one of them is an ExportedType, the other one must be too
			if ((ea = ia as ExportedType) is not null | (eb = ib as ExportedType) is not null) {
				result = Equals(ea, eb);
				checkResolve = false;
			}
			else if (DontCompareTypeScope)
				result = true;
			// only compare if both are files
			else if ((fa = ia as FileDef) is not null & (fb = ib as FileDef) is not null)
				result = Equals(fa, fb);
			// only compare if both are assemblies
			else if ((aa = ia as AssemblyRef) is not null & (ab = ib as AssemblyRef) is not null)
				result = Equals(aa, a, ab, b);
			else if (fa is not null && ab is not null)
				result = Equals(a.DefinitionAssembly, ab, b);
			else if (fb is not null && aa is not null)
				result = Equals(b.DefinitionAssembly, aa, a);
			else {
				result = false;
				checkResolve = false;
			}
			if (!result && checkResolve && !DontCheckTypeEquivalence) {
				var td1 = a.Resolve();
				var td2 = b.Resolve();
				if (td1 is not null && td2 is not null)
					result = TypeDefScopeEquals(td1, td2);
			}

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares resolution scope and implementation
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		bool EqualsScope(TypeRef a, ExportedType b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			var ra = a.ResolutionScope;
			var ib = b.Implementation;
			if (ra == ib)
				return true;
			if (ra is null || ib is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;
			TypeRef ea;
			ExportedType eb;
			IModule ma;
			FileDef fb;
			AssemblyRef aa, ab;
			bool checkResolve = true;

			// If one is a nested type, the other one must be too
			if ((ea = ra as TypeRef) is not null | (eb = ib as ExportedType) is not null) {
				result = Equals(ea, eb);
				checkResolve = false;
			}
			else if (DontCompareTypeScope)
				result = true;
			else if ((ma = ra as IModule) is not null & (fb = ib as FileDef) is not null)
				result = Equals(a, ma, b, fb);
			else if ((aa = ra as AssemblyRef) is not null & (ab = ib as AssemblyRef) is not null)
				result = Equals(aa, a, ab, b);
			else if (ma is not null && ab is not null)
				result = Equals(a.DefinitionAssembly, ab, b);
			else if (fb is not null && aa is not null)
				result = Equals(b.DefinitionAssembly, aa, a);
			else {
				checkResolve = false;
				result = false;
			}
			if (!result && checkResolve && !DontCheckTypeEquivalence) {
				var td1 = a.Resolve();
				var td2 = b.Resolve();
				if (td1 is not null && td2 is not null)
					result = TypeDefScopeEquals(td1, td2);
			}

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares files
		/// </summary>
		/// <param name="a">File #1</param>
		/// <param name="b">File #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		bool Equals(FileDef a, FileDef b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;

			return UTF8String.CaseInsensitiveEquals(a.Name, b.Name);
		}

		/// <summary>
		/// Compares a module with a file
		/// </summary>
		/// <param name="a">Module</param>
		/// <param name="b">File</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		bool Equals(IModule a, FileDef b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;

			//TODO: You should compare against the module's file name, not the name in the metadata!
			return UTF8String.CaseInsensitiveEquals(a.Name, b.Name);
		}

		/// <summary>
		/// Compares modules
		/// </summary>
		/// <param name="a">Module #1</param>
		/// <param name="b">Module #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		internal bool Equals(IModule a, IModule b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!MscorlibIsNotSpecial && IsCorLib(a) && IsCorLib(b))
				return true;

			return UTF8String.CaseInsensitiveEquals(a.Name, b.Name);
		}

		static bool IsCorLib(ModuleDef a) => a is not null && a.IsManifestModule && a.Assembly.IsCorLib();

		static bool IsCorLib(IModule a) {
			var mod = a as ModuleDef;
			return mod is not null && mod.IsManifestModule && mod.Assembly.IsCorLib();
		}

		static bool IsCorLib(Module a) => a is not null && a.Assembly.ManifestModule == a && a.Assembly == typeof(void).Assembly;
		static bool IsCorLib(IAssembly a) => a.IsCorLib();
		static bool IsCorLib(Assembly a) => a == typeof(void).Assembly;

		/// <summary>
		/// Compares modules
		/// </summary>
		/// <param name="a">Module #1</param>
		/// <param name="b">Module #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		bool Equals(ModuleDef a, ModuleDef b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!MscorlibIsNotSpecial && IsCorLib(a) && IsCorLib(b))
				return true;
			if (!recursionCounter.Increment())
				return false;

			bool result = Equals((IModule)a, (IModule)b) && Equals(a.Assembly, b.Assembly);

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares assemblies
		/// </summary>
		/// <param name="a">Assembly #1</param>
		/// <param name="b">Assembly #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		bool Equals(IAssembly a, IAssembly b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!MscorlibIsNotSpecial && IsCorLib(a) && IsCorLib(b))
				return true;
			if (!recursionCounter.Increment())
				return false;

			bool result = UTF8String.CaseInsensitiveEquals(a.Name, b.Name) &&
				(!CompareAssemblyPublicKeyToken || PublicKeyBase.TokenEquals(a.PublicKeyOrToken, b.PublicKeyOrToken)) &&
				(!CompareAssemblyVersion || Utils.Equals(a.Version, b.Version)) &&
				(!CompareAssemblyLocale || Utils.LocaleEquals(a.Culture, b.Culture));

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeSig a, TypeSig b) {
			if (IgnoreModifiers) {
				a = a.RemoveModifiers();
				b = b.RemoveModifiers();
			}
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;
			bool result;

			if (!DontProjectWinMDRefs) {
				a = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a) ?? a;
				b = WinMDHelpers.ToCLR(b.Module ?? sourceModule, b) ?? b;
			}

			if (a.ElementType != b.ElementType) {
				// Signatures must be identical. It's possible to have a U4 in a sig (short form
				// of System.UInt32), or a ValueType + System.UInt32 TypeRef (long form), but these
				// should not match in a sig (also the long form is invalid).
				result = false;
			}
			else {
				switch (a.ElementType) {
				case ElementType.Void:
				case ElementType.Boolean:
				case ElementType.Char:
				case ElementType.I1:
				case ElementType.U1:
				case ElementType.I2:
				case ElementType.U2:
				case ElementType.I4:
				case ElementType.U4:
				case ElementType.I8:
				case ElementType.U8:
				case ElementType.R4:
				case ElementType.R8:
				case ElementType.String:
				case ElementType.TypedByRef:
				case ElementType.I:
				case ElementType.U:
				case ElementType.Object:
				case ElementType.Sentinel:
					result = true;
					break;

				case ElementType.Ptr:
				case ElementType.ByRef:
				case ElementType.SZArray:
				case ElementType.Pinned:
					result = Equals(a.Next, b.Next);
					break;

				case ElementType.Array:
					ArraySig ara = a as ArraySig, arb = b as ArraySig;
					result = ara.Rank == arb.Rank &&
							(IgnoreMultiDimensionalArrayLowerBoundsAndSizes ||
							(Equals(ara.Sizes, arb.Sizes) &&
							Equals(ara.LowerBounds, arb.LowerBounds))) &&
							Equals(a.Next, b.Next);
					break;

				case ElementType.ValueType:
				case ElementType.Class:
					if (RawSignatureCompare)
						result = TokenEquals((a as ClassOrValueTypeSig).TypeDefOrRef, (b as ClassOrValueTypeSig).TypeDefOrRef);
					else
						result = Equals((IType)(a as ClassOrValueTypeSig).TypeDefOrRef, (IType)(b as ClassOrValueTypeSig).TypeDefOrRef);
					break;

				case ElementType.Var:
				case ElementType.MVar:
					result = (a as GenericSig).Number == (b as GenericSig).Number;
					break;

				case ElementType.GenericInst:
					var gia = (GenericInstSig)a;
					var gib = (GenericInstSig)b;
					if (RawSignatureCompare) {
						var gt1 = gia.GenericType;
						var gt2 = gib.GenericType;
						result = TokenEquals(gt1?.TypeDefOrRef, gt2?.TypeDefOrRef) &&
								Equals(gia.GenericArguments, gib.GenericArguments);
					}
					else {
						result = Equals(gia.GenericType, gib.GenericType) &&
								Equals(gia.GenericArguments, gib.GenericArguments);
					}
					break;

				case ElementType.FnPtr:
					result = Equals((a as FnPtrSig).Signature, (b as FnPtrSig).Signature);
					break;

				case ElementType.CModReqd:
				case ElementType.CModOpt:
					if (RawSignatureCompare)
						result = TokenEquals((a as ModifierSig).Modifier, (b as ModifierSig).Modifier) &&
								Equals(a.Next, b.Next);
					else
						result = Equals((IType)(a as ModifierSig).Modifier, (IType)(b as ModifierSig).Modifier) &&
								Equals(a.Next, b.Next);
					break;

				case ElementType.ValueArray:
					result = (a as ValueArraySig).Size == (b as ValueArraySig).Size && Equals(a.Next, b.Next);
					break;

				case ElementType.Module:
					result = (a as ModuleSig).Index == (b as ModuleSig).Index && Equals(a.Next, b.Next);
					break;

				case ElementType.End:
				case ElementType.R:
				case ElementType.Internal:
				default:
					result = false;
					break;
				}
			}

			recursionCounter.Decrement();
			return result;
		}

		static bool TokenEquals(ITypeDefOrRef a, ITypeDefOrRef b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			return a.MDToken == b.MDToken;
		}

		/// <summary>
		/// Gets the hash code of a type
		/// </summary>
		/// <param name="a">The type</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(TypeSig a) => GetHashCode(a, true);

		int GetHashCode(TypeSig a, bool substituteGenericParameters) {
			// ********************************************
			// IMPORTANT: This must match GetHashCode(Type)
			// ********************************************
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;
			int hash;

			if (substituteGenericParameters && genericArguments is not null) {
				var t = a;
				a = genericArguments.Resolve(a);
				substituteGenericParameters = t == a;
			}

			switch (a.ElementType) {
			case ElementType.Void:
			case ElementType.Boolean:
			case ElementType.Char:
			case ElementType.I1:
			case ElementType.U1:
			case ElementType.I2:
			case ElementType.U2:
			case ElementType.I4:
			case ElementType.U4:
			case ElementType.I8:
			case ElementType.U8:
			case ElementType.R4:
			case ElementType.R8:
			case ElementType.String:
			case ElementType.TypedByRef:
			case ElementType.I:
			case ElementType.U:
			case ElementType.Object:
			case ElementType.ValueType:
			case ElementType.Class:
				// When comparing an ExportedType/TypeDef/TypeRef to a TypeDefOrRefSig/Class/ValueType,
				// the ET is ignored, so we must ignore it when calculating the hash.
				hash = GetHashCode((IType)(a as TypeDefOrRefSig).TypeDefOrRef);
				break;

			case ElementType.Sentinel:
				hash = HASHCODE_MAGIC_ET_SENTINEL;
				break;

			case ElementType.Ptr:
				hash = HASHCODE_MAGIC_ET_PTR + GetHashCode(a.Next, substituteGenericParameters);
				break;

			case ElementType.ByRef:
				hash = HASHCODE_MAGIC_ET_BYREF + GetHashCode(a.Next, substituteGenericParameters);
				break;

			case ElementType.SZArray:
				hash = HASHCODE_MAGIC_ET_SZARRAY + GetHashCode(a.Next, substituteGenericParameters);
				break;

			case ElementType.CModReqd:
			case ElementType.CModOpt:
			case ElementType.Pinned:
				// When comparing an ExportedType/TypeDef/TypeRef to a ModifierSig/PinnedSig,
				// the ET is ignored, so we must ignore it when calculating the hash.
				hash = GetHashCode(a.Next, substituteGenericParameters);
				break;

			case ElementType.Array:
				// Don't include sizes and lower bounds since GetHashCode(Type) doesn't (and can't).
				// Also, if IgnoreMultiDimensionArrayLowerBoundsAndSizes is set, we shouldn't include them either.
				var ara = (ArraySig)a;
				hash = HASHCODE_MAGIC_ET_ARRAY + (int)ara.Rank + GetHashCode(ara.Next, substituteGenericParameters);
				break;

			case ElementType.Var:
				hash = HASHCODE_MAGIC_ET_VAR + (int)(a as GenericVar).Number;
				break;

			case ElementType.MVar:
				hash = HASHCODE_MAGIC_ET_MVAR + (int)(a as GenericMVar).Number;
				break;

			case ElementType.GenericInst:
				var gia = (GenericInstSig)a;
				hash = HASHCODE_MAGIC_ET_GENERICINST;
				hash += GetHashCode(gia.GenericType, substituteGenericParameters);
				hash += GetHashCode(gia.GenericArguments, substituteGenericParameters);
				break;

			case ElementType.FnPtr:
				hash = GetHashCode_FnPtr_SystemIntPtr();
				break;

			case ElementType.ValueArray:
				hash = HASHCODE_MAGIC_ET_VALUEARRAY + (int)(a as ValueArraySig).Size + GetHashCode(a.Next, substituteGenericParameters);
				break;

			case ElementType.Module:
				hash = HASHCODE_MAGIC_ET_MODULE + (int)(a as ModuleSig).Index + GetHashCode(a.Next, substituteGenericParameters);
				break;

			case ElementType.End:
			case ElementType.R:
			case ElementType.Internal:
			default:
				hash = 0;
				break;
			}

			recursionCounter.Decrement();
			return hash;
		}

		/// <summary>
		/// Compares type lists
		/// </summary>
		/// <param name="a">Type list #1</param>
		/// <param name="b">Type list #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(IList<TypeSig> a, IList<TypeSig> b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;
			bool result;

			if (a.Count != b.Count)
				result = false;
			else {
				int i;
				for (i = 0; i < a.Count; i++) {
					if (!Equals(a[i], b[i]))
						break;
				}
				result = i == a.Count;
			}

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a type list
		/// </summary>
		/// <param name="a">The type list</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(IList<TypeSig> a) => GetHashCode(a, true);

		int GetHashCode(IList<TypeSig> a, bool substituteGenericParameters) {
			//************************************************************************
			// IMPORTANT: This code must match any other GetHashCode(IList<SOME_TYPE>)
			//************************************************************************
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;
			uint hash = 0;
			for (int i = 0; i < a.Count; i++) {
				hash += (uint)GetHashCode(a[i], substituteGenericParameters);
				hash = (hash << 13) | (hash >> 19);
			}
			recursionCounter.Decrement();
			return (int)hash;
		}

		bool Equals(IList<uint> a, IList<uint> b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (a.Count != b.Count)
				return false;
			for (int i = 0; i < a.Count; i++) {
				if (a[i] != b[i])
					return false;
			}
			return true;
		}

		bool Equals(IList<int> a, IList<int> b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (a.Count != b.Count)
				return false;
			for (int i = 0; i < a.Count; i++) {
				if (a[i] != b[i])
					return false;
			}
			return true;
		}

		/// <summary>
		/// Compares signatures
		/// </summary>
		/// <param name="a">Sig #1</param>
		/// <param name="b">Sig #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(CallingConventionSig a, CallingConventionSig b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;
			bool result;

			if (a.GetCallingConvention() != b.GetCallingConvention())
				result = false;
			else {
				switch (a.GetCallingConvention() & CallingConvention.Mask) {
				case CallingConvention.Default:
				case CallingConvention.C:
				case CallingConvention.StdCall:
				case CallingConvention.ThisCall:
				case CallingConvention.FastCall:
				case CallingConvention.VarArg:
				case CallingConvention.Property:
				case CallingConvention.NativeVarArg:
				case CallingConvention.Unmanaged:
					MethodBaseSig ma = a as MethodBaseSig, mb = b as MethodBaseSig;
					result = ma is not null && mb is not null && Equals(ma, mb);
					break;

				case CallingConvention.Field:
					FieldSig fa = a as FieldSig, fb = b as FieldSig;
					result = fa is not null && fb is not null && Equals(fa, fb);
					break;

				case CallingConvention.LocalSig:
					LocalSig la = a as LocalSig, lb = b as LocalSig;
					result = la is not null && lb is not null && Equals(la, lb);
					break;

				case CallingConvention.GenericInst:
					GenericInstMethodSig ga = a as GenericInstMethodSig, gb = b as GenericInstMethodSig;
					result = ga is not null && gb is not null && Equals(ga, gb);
					break;

				default:
					result = false;
					break;
				}
			}

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a sig
		/// </summary>
		/// <param name="a">The sig</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(CallingConventionSig a) {
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;
			int hash;

			switch (a.GetCallingConvention() & CallingConvention.Mask) {
			case CallingConvention.Default:
			case CallingConvention.C:
			case CallingConvention.StdCall:
			case CallingConvention.ThisCall:
			case CallingConvention.FastCall:
			case CallingConvention.VarArg:
			case CallingConvention.Property:
			case CallingConvention.NativeVarArg:
			case CallingConvention.Unmanaged:
				var ma = a as MethodBaseSig;
				hash = ma is null ? 0 : GetHashCode(ma);
				break;

			case CallingConvention.Field:
				var fa = a as FieldSig;
				hash = fa is null ? 0 : GetHashCode(fa);
				break;

			case CallingConvention.LocalSig:
				var la = a as LocalSig;
				hash = la is null ? 0 : GetHashCode(la);
				break;

			case CallingConvention.GenericInst:
				var ga = a as GenericInstMethodSig;
				hash = ga is null ? 0 : GetHashCode(ga);
				break;

			default:
				hash = GetHashCode_CallingConvention(a);
				break;
			}

			recursionCounter.Decrement();
			return hash;
		}

		/// <summary>
		/// Compares method/property sigs
		/// </summary>
		/// <param name="a">Method/property #1</param>
		/// <param name="b">Method/property #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(MethodBaseSig a, MethodBaseSig b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result = a.GetCallingConvention() == b.GetCallingConvention() &&
					(DontCompareReturnType || Equals(a.RetType, b.RetType)) &&
					(!CompareMethodParams || Equals(a.Params, b.Params)) &&
					(!a.Generic || a.GenParamCount == b.GenParamCount) &&
					(!CompareSentinelParams || Equals(a.ParamsAfterSentinel, b.ParamsAfterSentinel));

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a method/property sig
		/// </summary>
		/// <param name="a">The method/property sig</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(MethodBaseSig a) {
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;
			int hash;

			hash = GetHashCode_CallingConvention(a) +
					GetHashCode(a.Params);
			if (!DontCompareReturnType)
				hash += GetHashCode(a.RetType);
			if (a.Generic)
				hash += GetHashCode_ElementType_MVar((int)a.GenParamCount);
			if (CompareSentinelParams)
				hash += GetHashCode(a.ParamsAfterSentinel);

			recursionCounter.Decrement();
			return hash;
		}

		int GetHashCode_CallingConvention(CallingConventionSig a) => GetHashCode(a.GetCallingConvention());

		int GetHashCode(CallingConvention a) {
			//*******************************************************************
			// IMPORTANT: This hash must match the Reflection call conv hash code
			//*******************************************************************

			switch (a & CallingConvention.Mask) {
			case CallingConvention.Default:
			case CallingConvention.C:
			case CallingConvention.StdCall:
			case CallingConvention.ThisCall:
			case CallingConvention.FastCall:
			case CallingConvention.VarArg:
			case CallingConvention.Property:
			case CallingConvention.GenericInst:
			case CallingConvention.Unmanaged:
			case CallingConvention.NativeVarArg:
			case CallingConvention.Field:
				return (int)(a & (CallingConvention.Generic | CallingConvention.HasThis | CallingConvention.ExplicitThis));

			case CallingConvention.LocalSig:
			default:
				return (int)a;
			}
		}

		/// <summary>
		/// Compares field sigs
		/// </summary>
		/// <param name="a">Field sig #1</param>
		/// <param name="b">Field sig #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(FieldSig a, FieldSig b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result = a.GetCallingConvention() == b.GetCallingConvention() && Equals(a.Type, b.Type);

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a field sig
		/// </summary>
		/// <param name="a">The field sig</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(FieldSig a) {
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;
			int hash;

			hash = GetHashCode_CallingConvention(a) + GetHashCode(a.Type);

			recursionCounter.Decrement();
			return hash;
		}

		/// <summary>
		/// Compares local sigs
		/// </summary>
		/// <param name="a">Local sig #1</param>
		/// <param name="b">Local sig #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(LocalSig a, LocalSig b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result = a.GetCallingConvention() == b.GetCallingConvention() && Equals(a.Locals, b.Locals);

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a local sig
		/// </summary>
		/// <param name="a">The local sig</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(LocalSig a) {
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;
			int hash;

			hash = GetHashCode_CallingConvention(a) + GetHashCode(a.Locals);

			recursionCounter.Decrement();
			return hash;
		}

		/// <summary>
		/// Compares generic method instance sigs
		/// </summary>
		/// <param name="a">Generic inst method #1</param>
		/// <param name="b">Generic inst method #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(GenericInstMethodSig a, GenericInstMethodSig b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result = a.GetCallingConvention() == b.GetCallingConvention() && Equals(a.GenericArguments, b.GenericArguments);

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a generic instance method sig
		/// </summary>
		/// <param name="a">The generic inst method sig</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(GenericInstMethodSig a) {
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;
			int hash;

			hash = GetHashCode_CallingConvention(a) + GetHashCode(a.GenericArguments);

			recursionCounter.Decrement();
			return hash;
		}

		/// <summary>
		/// Compares methods
		/// </summary>
		/// <param name="a">Method #1</param>
		/// <param name="b">Method #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(IMethod a, IMethod b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;
			MethodDef mda, mdb;
			MemberRef mra, mrb;
			MethodSpec msa, msb;

			if ((mda = a as MethodDef) is not null & (mdb = b as MethodDef) is not null)
				result = Equals(mda, mdb);
			else if ((mra = a as MemberRef) is not null & (mrb = b as MemberRef) is not null)
				result = Equals(mra, mrb);
			else if ((msa = a as MethodSpec) is not null && (msb = b as MethodSpec) is not null)
				result = Equals(msa, msb);
			else if (mda is not null && mrb is not null)
				result = Equals(mda, mrb);
			else if (mra is not null && mdb is not null)
				result = Equals(mdb, mra);
			else
				result = false;

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a method
		/// </summary>
		/// <param name="a">The method</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(IMethod a) {
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;

			int hash;
			MethodDef mda;
			MemberRef mra;
			MethodSpec msa;

			if ((mda = a as MethodDef) is not null)
				hash = GetHashCode(mda);
			else if ((mra = a as MemberRef) is not null)
				hash = GetHashCode(mra);
			else if ((msa = a as MethodSpec) is not null)
				hash = GetHashCode(msa);
			else
				hash = 0;

			recursionCounter.Decrement();
			return hash;
		}

		/// <summary>
		/// Compares methods
		/// </summary>
		/// <param name="a">Method #1</param>
		/// <param name="b">Method #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(MemberRef a, MethodDef b) => Equals(b, a);

		/// <summary>
		/// Compares methods
		/// </summary>
		/// <param name="a">Method #1</param>
		/// <param name="b">Method #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(MethodDef a, MemberRef b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;
			if (!DontProjectWinMDRefs) {
				var mra = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a);
				b = WinMDHelpers.ToCLR(b.Module ?? sourceModule, b) ?? b;
				if (mra is not null) {
					result = Equals(mra, b);
					goto exit;
				}
			}
			result = (PrivateScopeMethodIsComparable || !a.IsPrivateScope) &&
					Equals_MethodFieldNames(a.Name, b.Name) &&
					Equals(a.Signature, b.Signature) &&
					(!CompareMethodFieldDeclaringType || Equals(a.DeclaringType, b.Class));

exit:;
			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares methods
		/// </summary>
		/// <param name="a">Method #1</param>
		/// <param name="b">Method #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(MethodDef a, MethodDef b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (ReferenceCompareForMemberDefsInSameModule && InSameModule(a, b))
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;
			if (!DontProjectWinMDRefs) {
				var mra = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a);
				var mrb = WinMDHelpers.ToCLR(b.Module ?? sourceModule, b);
				if (mra is not null || mrb is not null) {
					result = Equals((IMethod)mra ?? a, (IMethod)mrb ?? b);
					goto exit;
				}
			}
			result = Equals_MethodFieldNames(a.Name, b.Name) &&
					Equals(a.Signature, b.Signature) &&
					(!CompareMethodFieldDeclaringType || Equals(a.DeclaringType, b.DeclaringType));

exit:;
			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a method
		/// </summary>
		/// <param name="a">The method</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(MethodDef a) {
			// ***********************************************************************
			// IMPORTANT: This hash code must match the MemberRef/MethodBase hash code
			// ***********************************************************************
			if (a is null)
				return 0;
			if (!DontProjectWinMDRefs) {
				var mra = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a);
				if (mra is not null)
					return GetHashCode(mra);
			}

			if (!recursionCounter.Increment())
				return 0;

			int hash = GetHashCode_MethodFieldName(a.Name) +
					GetHashCode(a.Signature);
			if (CompareMethodFieldDeclaringType)
				hash += GetHashCode(a.DeclaringType);

			recursionCounter.Decrement();
			return hash;
		}

		/// <summary>
		/// Compares <c>MemberRef</c>s
		/// </summary>
		/// <param name="a"><c>MemberRef</c> #1</param>
		/// <param name="b"><c>MemberRef</c> #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(MemberRef a, MemberRef b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			if (!DontProjectWinMDRefs) {
				a = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a) ?? a;
				b = WinMDHelpers.ToCLR(b.Module ?? sourceModule, b) ?? b;
			}
			bool result = Equals_MethodFieldNames(a.Name, b.Name) &&
					Equals(a.Signature, b.Signature) &&
					(!CompareMethodFieldDeclaringType || Equals(a.Class, b.Class));

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a <c>MemberRef</c>
		/// </summary>
		/// <param name="a">The <c>MemberRef</c></param>
		/// <returns>The hash code</returns>
		public int GetHashCode(MemberRef a) {
			// ********************************************************************************
			// IMPORTANT: This hash code must match the MethodDef/FieldDef/MethodBase hash code
			// ********************************************************************************
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;

			if (!DontProjectWinMDRefs)
				a = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a) ?? a;

			int hash = GetHashCode_MethodFieldName(a.Name);
			GenericInstSig git;
			if (CompareMethodFieldDeclaringType && !DontSubstituteGenericParameters && (git = GetGenericInstanceType(a.Class)) is not null) {
				InitializeGenericArguments();
				genericArguments.PushTypeArgs(git.GenericArguments);
				hash += GetHashCode(a.Signature);
				genericArguments.PopTypeArgs();
			}
			else
				hash += GetHashCode(a.Signature);
			if (CompareMethodFieldDeclaringType)
				hash += GetHashCode(a.Class);

			recursionCounter.Decrement();
			return hash;
		}

		/// <summary>
		/// Compares <c>MethodSpec</c>s
		/// </summary>
		/// <param name="a"><c>MethodSpec</c> #1</param>
		/// <param name="b"><c>MethodSpec</c> #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(MethodSpec a, MethodSpec b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result = Equals(a.Method, b.Method) && Equals(a.Instantiation, b.Instantiation);

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a <c>MethodSpec</c>
		/// </summary>
		/// <param name="a">The <c>MethodSpec</c></param>
		/// <returns>The hash code</returns>
		public int GetHashCode(MethodSpec a) {
			// *************************************************************
			// IMPORTANT: This hash code must match the MethodBase hash code
			// *************************************************************
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;

			var gim = a.GenericInstMethodSig;
			if (gim is not null) {
				InitializeGenericArguments();
				genericArguments.PushMethodArgs(gim.GenericArguments);
			}
			int hash = GetHashCode(a.Method);
			if (gim is not null)
				genericArguments.PopMethodArgs();

			recursionCounter.Decrement();
			return hash;
		}

		/// <summary>
		/// Compares <c>MemberRefParent</c>s
		/// </summary>
		/// <param name="a"><c>MemberRefParent</c> #1</param>
		/// <param name="b"><c>MemberRefParent</c> #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		bool Equals(IMemberRefParent a, IMemberRefParent b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;
			ITypeDefOrRef ita, itb;
			ModuleRef moda, modb;
			MethodDef ma, mb;
			TypeDef td;

			if ((ita = a as ITypeDefOrRef) is not null && (itb = b as ITypeDefOrRef) is not null)
				result = Equals((IType)ita, (IType)itb);
			else if ((moda = a as ModuleRef) is not null & (modb = b as ModuleRef) is not null) {
				ModuleDef omoda = moda.Module, omodb = modb.Module;
				result = Equals((IModule)moda, (IModule)modb) &&
						Equals(omoda?.Assembly, omodb?.Assembly);
			}
			else if ((ma = a as MethodDef) is not null && (mb = b as MethodDef) is not null)
				result = Equals(ma, mb);
			else if (modb is not null && (td = a as TypeDef) is not null)
				result = EqualsGlobal(td, modb);
			else if (moda is not null && (td = b as TypeDef) is not null)
				result = EqualsGlobal(td, moda);
			else
				result = false;

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a <c>MemberRefParent</c>
		/// </summary>
		/// <param name="a">The <c>MemberRefParent</c></param>
		/// <returns>The hash code</returns>
		int GetHashCode(IMemberRefParent a) {
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;

			int hash;
			ITypeDefOrRef ita;
			MethodDef ma;

			if ((ita = a as ITypeDefOrRef) is not null)
				hash = GetHashCode((IType)ita);
			else if (a is ModuleRef)
				hash = GetHashCodeGlobalType();
			else if ((ma = a as MethodDef) is not null) {
				// Only use the declaring type so we get the same hash code when hashing a MethodBase.
				hash = GetHashCode(ma.DeclaringType);
			}
			else
				hash = 0;

			recursionCounter.Decrement();
			return hash;
		}

		/// <summary>
		/// Compares fields
		/// </summary>
		/// <param name="a">Field #1</param>
		/// <param name="b">Field #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(IField a, IField b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;
			FieldDef fa, fb;
			MemberRef ma, mb;

			if ((fa = a as FieldDef) is not null & (fb = b as FieldDef) is not null)
				result = Equals(fa, fb);
			else if ((ma = a as MemberRef) is not null & (mb = b as MemberRef) is not null)
				result = Equals(ma, mb);
			else if (fa is not null && mb is not null)
				result = Equals(fa, mb);
			else if (fb is not null && ma is not null)
				result = Equals(fb, ma);
			else
				result = false;

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a field
		/// </summary>
		/// <param name="a">The field</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(IField a) {
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;

			int hash;
			FieldDef fa;
			MemberRef ma;

			if ((fa = a as FieldDef) is not null)
				hash = GetHashCode(fa);
			else if ((ma = a as MemberRef) is not null)
				hash = GetHashCode(ma);
			else
				hash = 0;

			recursionCounter.Decrement();
			return hash;
		}

		/// <summary>
		/// Compares fields
		/// </summary>
		/// <param name="a">Field #1</param>
		/// <param name="b">Field #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(MemberRef a, FieldDef b) => Equals(b, a);

		/// <summary>
		/// Compares fields
		/// </summary>
		/// <param name="a">Field #1</param>
		/// <param name="b">Field #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(FieldDef a, MemberRef b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result = (PrivateScopeFieldIsComparable || !a.IsPrivateScope) &&
					Equals_MethodFieldNames(a.Name, b.Name) &&
					Equals(a.Signature, b.Signature) &&
					(!CompareMethodFieldDeclaringType || Equals(a.DeclaringType, b.Class));

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares fields
		/// </summary>
		/// <param name="a">Field #1</param>
		/// <param name="b">Field #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(FieldDef a, FieldDef b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (ReferenceCompareForMemberDefsInSameModule && InSameModule(a, b))
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result = Equals_MethodFieldNames(a.Name, b.Name) &&
					Equals(a.Signature, b.Signature) &&
					(!CompareMethodFieldDeclaringType || Equals(a.DeclaringType, b.DeclaringType));

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a field
		/// </summary>
		/// <param name="a">The field</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(FieldDef a) {
			// **********************************************************************
			// IMPORTANT: This hash code must match the MemberRef/FieldInfo hash code
			// **********************************************************************
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;

			int hash = GetHashCode_MethodFieldName(a.Name) +
					GetHashCode(a.Signature);
			if (CompareMethodFieldDeclaringType)
				hash += GetHashCode(a.DeclaringType);

			recursionCounter.Decrement();
			return hash;
		}

		/// <summary>
		/// Compares properties
		/// </summary>
		/// <param name="a">Property #1</param>
		/// <param name="b">Property #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(PropertyDef a, PropertyDef b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (ReferenceCompareForMemberDefsInSameModule && InSameModule(a, b))
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result = Equals_PropertyNames(a.Name, b.Name) &&
					Equals(a.Type, b.Type) &&
					(!ComparePropertyDeclaringType || Equals(a.DeclaringType, b.DeclaringType));

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a property
		/// </summary>
		/// <param name="a">The property</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(PropertyDef a) {
			// ***************************************************************
			// IMPORTANT: This hash code must match the PropertyInfo hash code
			// ***************************************************************
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;

			var sig = a.PropertySig;
			int hash = GetHashCode_PropertyName(a.Name) +
					GetHashCode(sig?.RetType);
			if (ComparePropertyDeclaringType)
				hash += GetHashCode(a.DeclaringType);

			recursionCounter.Decrement();
			return hash;
		}

		/// <summary>
		/// Compares events
		/// </summary>
		/// <param name="a">Event #1</param>
		/// <param name="b">Event #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(EventDef a, EventDef b) {
			if (a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (ReferenceCompareForMemberDefsInSameModule && InSameModule(a, b))
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result = Equals_EventNames(a.Name, b.Name) &&
					Equals((IType)a.EventType, (IType)b.EventType) &&
					(!CompareEventDeclaringType || Equals(a.DeclaringType, b.DeclaringType));

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of an event
		/// </summary>
		/// <param name="a">The event</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(EventDef a) {
			// ************************************************************
			// IMPORTANT: This hash code must match the EventInfo hash code
			// ************************************************************
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;

			int hash = GetHashCode_EventName(a.Name) +
					GetHashCode((IType)a.EventType);
			if (CompareEventDeclaringType)
				hash += GetHashCode(a.DeclaringType);

			recursionCounter.Decrement();
			return hash;
		}

		// Compares a with b, and a must be the global type
		bool EqualsGlobal(TypeDef a, ModuleRef b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result = a.IsGlobalModuleType &&
				Equals((IModule)a.Module, (IModule)b) &&
				Equals(a.DefinitionAssembly, GetAssembly(b.Module));

			recursionCounter.Decrement();
			return result;
		}

		static AssemblyDef GetAssembly(ModuleDef module) => module?.Assembly;

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(Type a, IType b) => Equals(b, a);

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(IType a, Type b) {
			// Global methods and fields have their DeclaringType set to null. Assume
			// null always means the global type.
			if (a is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;
			TypeDef td;
			TypeRef tr;
			TypeSpec ts;
			TypeSig sig;
			ExportedType et;

			if ((td = a as TypeDef) is not null)
				result = Equals(td, b);
			else if ((tr = a as TypeRef) is not null)
				result = Equals(tr, b);
			else if ((ts = a as TypeSpec) is not null)
				result = Equals(ts, b);
			else if ((sig = a as TypeSig) is not null)
				result = Equals(sig, b);
			else if ((et = a as ExportedType) is not null)
				result = Equals(et, b);
			else
				result = false;

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(Type a, TypeDef b) => Equals(b, a);

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeDef a, Type b) {
			// Global methods and fields have their DeclaringType set to null. Assume
			// null always means the global type.
			if (a is null)
				return false;
			if (b is null)
				return a.IsGlobalModuleType;
			if (!recursionCounter.Increment())
				return false;

			bool result;

			if (!DontProjectWinMDRefs) {
				var tra = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a);
				if (tra is not null) {
					result = Equals(tra, b);
					goto exit;
				}
			}
			result = !b.HasElementType &&
					Equals_TypeNames(a.Name, ReflectionExtensions.Unescape(b.Name)) &&
					Equals_TypeNamespaces(a.Namespace, b) &&
					EnclosingTypeEquals(a.DeclaringType, b.DeclaringType) &&
					(DontCompareTypeScope || Equals(a.Module, b.Module));

exit:;
			recursionCounter.Decrement();
			return result;
		}

		bool EnclosingTypeEquals(TypeDef a, Type b) {
			// b is null doesn't mean that b is the global type
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			return Equals(a, b);
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(Type a, TypeRef b) => Equals(b, a);

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="b">Type #1</param>
		/// <param name="a">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeRef a, Type b) {
			// Global methods and fields have their DeclaringType set to null. Assume
			// null always means the global type.
			if (a is null)
				return false;
			if (b is null)
				return false;   // Must use a ModuleRef to reference the global type, so always fail
			if (!recursionCounter.Increment())
				return false;

			bool result;
			TypeRef dta;
			IModule aMod;
			AssemblyRef aAsm;
			if (!DontProjectWinMDRefs)
				a = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a) ?? a;

			var scope = a.ResolutionScope;

			if (!b.IsTypeDef())
				result = false;
			else if (!Equals_TypeNames(a.Name, ReflectionExtensions.Unescape(b.Name)) || !Equals_TypeNamespaces(a.Namespace, b))
				result = false;
			else if ((dta = scope as TypeRef) is not null)  // nested type
				result = Equals(dta, b.DeclaringType);  // Compare enclosing types
			else if (b.IsNested)
				result = false; // b is nested, a isn't
			else if (DontCompareTypeScope)
				result = true;
			else if ((aMod = scope as IModule) is not null) // 'a' is defined in the same assembly as 'b'
				result = Equals(b, aMod, a);
			else if ((aAsm = scope as AssemblyRef) is not null)
				result = Equals(b.Assembly, aAsm, a);
			else {
				result = false;
				//TODO: Handle the case where scope is null
			}

			recursionCounter.Decrement();
			return result;
		}

		bool Equals_TypeNamespaces(UTF8String a, Type b) {
			if (b.IsNested)
				return true;
			return Equals_TypeNamespaces(a, b.Namespace);
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(Type a, TypeSpec b) => Equals(b, a);

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeSpec a, Type b) {
			// Global methods and fields have their DeclaringType set to null. Assume
			// null always means the global type.
			if (a is null)
				return false;
			if (b is null)
				return false;   // Must use a ModuleRef to reference the global type, so always fail
			return Equals(a.TypeSig, b);
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(Type a, TypeSig b) => Equals(b, a);

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(TypeSig a, Type b) => Equals(a, b, null, false);

		bool Equals(ITypeDefOrRef a, Type b, Type declaringType) {
			if (a is TypeSpec ts)
				return Equals(ts.TypeSig, b, declaringType);
			return Equals(a, b);
		}

		/// <summary>
		/// Checks whether it's FnPtr&amp;, FnPtr*, FnPtr[], or FnPtr[...]
		/// </summary>
		/// <param name="a">The type</param>
		static bool IsFnPtrElementType(Type a) {
			if (a is null || !a.HasElementType)
				return false;
			var et = a.GetElementType();
			if (et is null || et.HasElementType)
				return false;
			if (et != typeof(IntPtr))   // FnPtr is mapped to System.IntPtr
				return false;
			if (!a.FullName.StartsWith("(fnptr)"))
				return false;

			return true;
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <param name="declaringType">Root declaring type to check if we should
		/// treat <paramref name="b"/> as a generic instance type</param>
		/// <param name="treatAsGenericInst"><c>true</c> if we should treat <paramref name="b"/>
		/// as a generic instance type</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		bool Equals(TypeSig a, Type b, Type declaringType, bool? treatAsGenericInst = null) {
			// Global methods and fields have their DeclaringType set to null. Assume
			// null always means the global type.
			if (a is null)
				return false;
			if (b is null)
				return false;   // Must use a ModuleRef to reference the global type, so always fail
			if (!recursionCounter.Increment())
				return false;
			bool result;

			bool treatAsGenericInst2 = treatAsGenericInst ?? declaringType.MustTreatTypeAsGenericInstType(b);
			if (genericArguments is not null)
				a = genericArguments.Resolve(a);

			switch (a.ElementType) {
			case ElementType.Void:
			case ElementType.Boolean:
			case ElementType.Char:
			case ElementType.I1:
			case ElementType.U1:
			case ElementType.I2:
			case ElementType.U2:
			case ElementType.I4:
			case ElementType.U4:
			case ElementType.I8:
			case ElementType.U8:
			case ElementType.R4:
			case ElementType.R8:
			case ElementType.String:
			case ElementType.TypedByRef:
			case ElementType.I:
			case ElementType.U:
			case ElementType.Object:
				result = Equals(((TypeDefOrRefSig)a).TypeDefOrRef, b, declaringType);
				break;

			case ElementType.Ptr:
				if (!b.IsPointer)
					result = false;
				else if (IsFnPtrElementType(b)) {
					a = a.Next.RemoveModifiers();
					result = a is not null && a.ElementType == ElementType.FnPtr;
				}
				else
					result = Equals(a.Next, b.GetElementType(), declaringType);
				break;

			case ElementType.ByRef:
				if (!b.IsByRef)
					result = false;
				else if (IsFnPtrElementType(b)) {
					a = a.Next.RemoveModifiers();
					result = a is not null && a.ElementType == ElementType.FnPtr;
				}
				else
					result = Equals(a.Next, b.GetElementType(), declaringType);
				break;

			case ElementType.SZArray:
				if (!b.IsArray || !b.IsSZArray())
					result = false;
				else if (IsFnPtrElementType(b)) {
					a = a.Next.RemoveModifiers();
					result = a is not null && a.ElementType == ElementType.FnPtr;
				}
				else
					result = Equals(a.Next, b.GetElementType(), declaringType);
				break;

			case ElementType.Pinned:
				result = Equals(a.Next, b, declaringType);
				break;

			case ElementType.Array:
				if (!b.IsArray || b.IsSZArray())
					result = false;
				else {
					var ara = a as ArraySig;
					result = ara.Rank == b.GetArrayRank() &&
						(IsFnPtrElementType(b) ?
								(a = a.Next.RemoveModifiers()) is not null && a.ElementType == ElementType.FnPtr :
								Equals(a.Next, b.GetElementType(), declaringType));
				}
				break;

			case ElementType.ValueType:
			case ElementType.Class:
				result = Equals((a as ClassOrValueTypeSig).TypeDefOrRef, b, declaringType);
				break;

			case ElementType.Var:
				result = b.IsGenericParameter &&
						b.GenericParameterPosition == (a as GenericSig).Number &&
						b.DeclaringMethod is null;
				break;

			case ElementType.MVar:
				result = b.IsGenericParameter &&
						b.GenericParameterPosition == (a as GenericSig).Number &&
						b.DeclaringMethod is not null;
				break;

			case ElementType.GenericInst:
				if (!(b.IsGenericType && !b.IsGenericTypeDefinition) && !treatAsGenericInst2) {
					result = false;
					break;
				}
				var gia = (GenericInstSig)a;
				result = Equals(gia.GenericType, b.GetGenericTypeDefinition(), null, false);
				result = result && Equals(gia.GenericArguments, b.GetGenericArguments(), declaringType);
				break;

			case ElementType.CModReqd:
			case ElementType.CModOpt:
				result = Equals(a.Next, b, declaringType);
				break;

			case ElementType.FnPtr:
				// At least in method sigs, this will be mapped to System.IntPtr
				result = b == typeof(IntPtr);
				break;

			case ElementType.Sentinel:
			case ElementType.ValueArray:
			case ElementType.Module:
			case ElementType.End:
			case ElementType.R:
			case ElementType.Internal:
			default:
				result = false;
				break;
			}

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="a">Type #1</param>
		/// <param name="b">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(Type a, ExportedType b) => Equals(b, a);

		/// <summary>
		/// Compares types
		/// </summary>
		/// <param name="b">Type #1</param>
		/// <param name="a">Type #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(ExportedType a, Type b) {
			// Global methods and fields have their DeclaringType set to null. Assume
			// null always means the global type.
			if (a is null)
				return false;
			if (b is null)
				return false;   // Must use a ModuleRef to reference the global type, so always fail
			if (!recursionCounter.Increment())
				return false;

			bool result;
			ExportedType dta;
			FileDef aFile;
			AssemblyRef aAsm;
			if (!DontProjectWinMDRefs)
				a = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a) ?? a;

			var scope = a.Implementation;

			if (!b.IsTypeDef())
				result = false;
			else if (!Equals_TypeNames(a.TypeName, ReflectionExtensions.Unescape(b.Name)) || !Equals_TypeNamespaces(a.TypeNamespace, b))
				result = false;
			else if ((dta = scope as ExportedType) is not null) // nested type
				result = Equals(dta, b.DeclaringType);  // Compare enclosing types
			else if (b.IsNested)
				result = false; // b is nested, a isn't
			else if (DontCompareTypeScope)
				result = true;
			else if ((aFile = scope as FileDef) is not null)
				result = Equals(b, aFile, a);
			else if ((aAsm = scope as AssemblyRef) is not null)
				result = Equals(b.Assembly, aAsm, a);
			else
				result = false;

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a type
		/// </summary>
		/// <param name="a">The type</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(Type a) => GetHashCode(a, false);

		/// <summary>
		/// Gets the hash code of a type
		/// </summary>
		/// <param name="a">The type</param>
		/// <param name="treatAsGenericInst"><c>true</c> if we should treat <paramref name="a"/>
		/// as a generic instance type</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(Type a, bool treatAsGenericInst) => GetHashCode(a, null, treatAsGenericInst);

		int GetHashCode(Type a, Type declaringType, bool? treatAsGenericInst = null) {
			// **************************************************************************
			// IMPORTANT: This hash code must match the TypeSig/TypeDef/TypeRef hash code
			// **************************************************************************
			if (a is null)  // Could be global type
				return GetHashCode_TypeDef(a);
			if (!recursionCounter.Increment())
				return 0;
			int hash;

			bool treatAsGenericInst2 = treatAsGenericInst ?? declaringType.MustTreatTypeAsGenericInstType(a);
			switch (treatAsGenericInst2 ? ElementType.GenericInst : a.GetElementType2()) {
			case ElementType.Void:
			case ElementType.Boolean:
			case ElementType.Char:
			case ElementType.I1:
			case ElementType.U1:
			case ElementType.I2:
			case ElementType.U2:
			case ElementType.I4:
			case ElementType.U4:
			case ElementType.I8:
			case ElementType.U8:
			case ElementType.R4:
			case ElementType.R8:
			case ElementType.String:
			case ElementType.TypedByRef:
			case ElementType.I:
			case ElementType.U:
			case ElementType.Object:
			case ElementType.ValueType:
			case ElementType.Class:
				hash = GetHashCode_TypeDef(a);
				break;

			case ElementType.FnPtr:
				hash = GetHashCode_FnPtr_SystemIntPtr();
				break;

			case ElementType.Sentinel:
				hash = HASHCODE_MAGIC_ET_SENTINEL;
				break;

			case ElementType.Ptr:
				hash = HASHCODE_MAGIC_ET_PTR +
					(IsFnPtrElementType(a) ? GetHashCode_FnPtr_SystemIntPtr() : GetHashCode(a.GetElementType(), declaringType));
				break;

			case ElementType.ByRef:
				hash = HASHCODE_MAGIC_ET_BYREF +
					(IsFnPtrElementType(a) ? GetHashCode_FnPtr_SystemIntPtr() : GetHashCode(a.GetElementType(), declaringType));
				break;

			case ElementType.SZArray:
				hash = HASHCODE_MAGIC_ET_SZARRAY +
					(IsFnPtrElementType(a) ? GetHashCode_FnPtr_SystemIntPtr() : GetHashCode(a.GetElementType(), declaringType));
				break;

			case ElementType.CModReqd:
			case ElementType.CModOpt:
			case ElementType.Pinned:
				hash = GetHashCode(a.GetElementType(), declaringType);
				break;

			case ElementType.Array:
				// The type doesn't store sizes and lower bounds, so can't use them to
				// create the hash
				hash = HASHCODE_MAGIC_ET_ARRAY + a.GetArrayRank() +
					(IsFnPtrElementType(a) ? GetHashCode_FnPtr_SystemIntPtr() : GetHashCode(a.GetElementType(), declaringType));
				break;

			case ElementType.Var:
				hash = HASHCODE_MAGIC_ET_VAR + a.GenericParameterPosition;
				break;

			case ElementType.MVar:
				hash = HASHCODE_MAGIC_ET_MVAR + a.GenericParameterPosition;
				break;

			case ElementType.GenericInst:
				hash = HASHCODE_MAGIC_ET_GENERICINST + GetHashCode(a.GetGenericTypeDefinition(), false) +
					GetHashCode(a.GetGenericArguments(), declaringType);
				break;

			case ElementType.ValueArray:
			case ElementType.Module:
			case ElementType.End:
			case ElementType.R:
			case ElementType.Internal:
			default:
				hash = 0;
				break;
			}

			recursionCounter.Decrement();
			return hash;
		}

		/// <summary>
		/// Gets the hash code of a type list
		/// </summary>
		/// <param name="a">The type list</param>
		/// <param name="declaringType">Root declaring type to check if we should
		/// treat <paramref name="a"/> as a generic instance type</param>
		/// <returns>The hash code</returns>
		int GetHashCode(IList<Type> a, Type declaringType) {
			//************************************************************************
			// IMPORTANT: This code must match any other GetHashCode(IList<SOME_TYPE>)
			//************************************************************************
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;
			uint hash = 0;
			for (int i = 0; i < a.Count; i++) {
				hash += (uint)GetHashCode(a[i], declaringType);
				hash = (hash << 13) | (hash >> 19);
			}
			recursionCounter.Decrement();
			return (int)hash;
		}

		/// <summary>
		/// Gets the hash code of a list with only generic method parameters (<see cref="ElementType.MVar"/>)
		/// </summary>
		/// <param name="numGenericParams">Number of generic method parameters</param>
		/// <returns>Hash code</returns>
		static int GetHashCode_ElementType_MVar(int numGenericParams) => GetHashCode(numGenericParams, HASHCODE_MAGIC_ET_MVAR);

		static int GetHashCode(int numGenericParams, int etypeHashCode) {
			//************************************************************************
			// IMPORTANT: This code must match any other GetHashCode(IList<SOME_TYPE>)
			//************************************************************************
			uint hash = 0;
			for (int i = 0; i < numGenericParams; i++) {
				hash += (uint)(etypeHashCode + i);
				hash = (hash << 13) | (hash >> 19);
			}
			return (int)hash;
		}

		/// <summary>
		/// Gets the hash code of a TypeDef type
		/// </summary>
		/// <param name="a">The type</param>
		/// <returns>The hash code</returns>
		public int GetHashCode_TypeDef(Type a) {
			// ************************************************************************************
			// IMPORTANT: This hash code must match the Type/TypeRef/TypeDef/ExportedType
			// hash code and GetHashCode_FnPtr_SystemIntPtr() method
			// ************************************************************************************

			// A global method/field's declaring type is null. This is the reason we must
			// return GetHashCodeGlobalType() here.
			if (a is null)
				return GetHashCodeGlobalType();
			int hash;
			hash = GetHashCode_TypeName(ReflectionExtensions.Unescape(a.Name));
			if (a.IsNested)
				hash += HASHCODE_MAGIC_NESTED_TYPE;
			else
				hash += GetHashCode_TypeNamespace(a.Namespace);
			return hash;
		}

		/// <summary>
		/// Compares type lists
		/// </summary>
		/// <param name="a">Type list #1</param>
		/// <param name="b">Type list #2</param>
		/// <param name="declaringType">Root declaring type to check if we should
		/// treat <paramref name="b"/> as a generic instance type</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		bool Equals(IList<TypeSig> a, IList<Type> b, Type declaringType) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;
			bool result;

			if (a.Count != b.Count)
				result = false;
			else {
				int i;
				for (i = 0; i < a.Count; i++) {
					if (!Equals(a[i], b[i], declaringType))
						break;
				}
				result = i == a.Count;
			}

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares modules
		/// </summary>
		/// <param name="a">Module #1</param>
		/// <param name="b">Module #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		bool Equals(ModuleDef a, Module b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!MscorlibIsNotSpecial && IsCorLib(a) && IsCorLib(b))
				return true;
			if (!recursionCounter.Increment())
				return false;

			bool result = Equals((IModule)a, b) && Equals(a.Assembly, b.Assembly);

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares a file and a module
		/// </summary>
		/// <param name="a">File</param>
		/// <param name="b">Module</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		bool Equals(FileDef a, Module b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;

			// Use b.Name since it's the filename we want to compare, not b.ScopeName
			return UTF8String.ToSystemStringOrEmpty(a.Name).Equals(b.Name, StringComparison.OrdinalIgnoreCase);
		}

		/// <summary>
		/// Compares modules
		/// </summary>
		/// <param name="a">Module #1</param>
		/// <param name="b">Module #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		bool Equals(IModule a, Module b) {
			if ((object)a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!MscorlibIsNotSpecial && IsCorLib(a) && IsCorLib(b))
				return true;

			// Use b.ScopeName and not b.Name since b.Name is just the file name w/o path
			return UTF8String.ToSystemStringOrEmpty(a.Name).Equals(b.ScopeName, StringComparison.OrdinalIgnoreCase);
		}

		/// <summary>
		/// Compares assemblies
		/// </summary>
		/// <param name="a">Assembly #1</param>
		/// <param name="b">Assembly #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		bool Equals(IAssembly a, Assembly b) {
			if ((object)a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!MscorlibIsNotSpecial && IsCorLib(a) && IsCorLib(b))
				return true;
			if (!recursionCounter.Increment())
				return false;

			var bAsmName = b.GetName();
			bool result = UTF8String.ToSystemStringOrEmpty(a.Name).Equals(bAsmName.Name, StringComparison.OrdinalIgnoreCase) &&
				(!CompareAssemblyPublicKeyToken || PublicKeyBase.TokenEquals(a.PublicKeyOrToken, new PublicKeyToken(bAsmName.GetPublicKeyToken()))) &&
				(!CompareAssemblyVersion || Utils.Equals(a.Version, bAsmName.Version)) &&
				(!CompareAssemblyLocale || Utils.LocaleEquals(a.Culture, bAsmName.CultureInfo.Name));

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares method declaring types
		/// </summary>
		/// <param name="a">Method #1</param>
		/// <param name="b">Method #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		bool DeclaringTypeEquals(IMethod a, MethodBase b) {
			// If this is disabled, always return true, even if one is null, etc.
			if (!CompareMethodFieldDeclaringType)
				return true;

			if ((object)a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;
			MethodDef md;
			MemberRef mr;
			MethodSpec ms;

			if ((md = a as MethodDef) is not null)
				result = DeclaringTypeEquals(md, b);
			else if ((mr = a as MemberRef) is not null)
				result = DeclaringTypeEquals(mr, b);
			else if ((ms = a as MethodSpec) is not null)
				result = DeclaringTypeEquals(ms, b);
			else
				result = false;

			recursionCounter.Decrement();
			return result;
		}

		bool DeclaringTypeEquals(MethodDef a, MethodBase b) {
			// If this is disabled, always return true, even if one is null, etc.
			if (!CompareMethodFieldDeclaringType)
				return true;
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			return Equals(a.DeclaringType, b.DeclaringType);
		}

		bool DeclaringTypeEquals(MemberRef a, MethodBase b) {
			// If this is disabled, always return true, even if one is null, etc.
			if (!CompareMethodFieldDeclaringType)
				return true;
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			return Equals(a.Class, b.DeclaringType, b.Module);
		}

		bool DeclaringTypeEquals(MethodSpec a, MethodBase b) {
			// If this is disabled, always return true, even if one is null, etc.
			if (!CompareMethodFieldDeclaringType)
				return true;
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			return DeclaringTypeEquals(a.Method, b);
		}

		/// <summary>
		/// Compares methods
		/// </summary>
		/// <param name="a">Method #1</param>
		/// <param name="b">Method #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(MethodBase a, IMethod b) => Equals(b, a);

		/// <summary>
		/// Compares methods
		/// </summary>
		/// <param name="a">Method #1</param>
		/// <param name="b">Method #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(IMethod a, MethodBase b) {
			if ((object)a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;
			MethodDef md;
			MemberRef mr;
			MethodSpec ms;

			if ((md = a as MethodDef) is not null)
				result = Equals(md, b);
			else if ((mr = a as MemberRef) is not null)
				result = Equals(mr, b);
			else if ((ms = a as MethodSpec) is not null)
				result = Equals(ms, b);
			else
				result = false;

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares methods
		/// </summary>
		/// <param name="a">Method #1</param>
		/// <param name="b">Method #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(MethodBase a, MethodDef b) => Equals(b, a);

		/// <summary>
		/// Compares methods
		/// </summary>
		/// <param name="a">Method #1</param>
		/// <param name="b">Method #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(MethodDef a, MethodBase b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;
			if (!DontProjectWinMDRefs) {
				var mra = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a);
				if (mra is not null) {
					result = Equals(mra, b);
					goto exit;
				}
			}

			var amSig = a.MethodSig;
			result = Equals_MethodFieldNames(a.Name, b.Name) &&
					amSig is not null &&
					((amSig.Generic && b.IsGenericMethodDefinition && b.IsGenericMethod) ||
					(!amSig.Generic && !b.IsGenericMethodDefinition && !b.IsGenericMethod)) &&
					Equals(amSig, b) &&
					(!CompareMethodFieldDeclaringType || Equals(a.DeclaringType, b.DeclaringType));

exit:;
			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares method sigs
		/// </summary>
		/// <param name="a">Method #1</param>
		/// <param name="b">Method #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(MethodBase a, MethodSig b) => Equals(b, a);

		/// <summary>
		/// Compares method sigs
		/// </summary>
		/// <param name="a">Method #1</param>
		/// <param name="b">Method #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(MethodSig a, MethodBase b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			if (!CompareMethodFieldDeclaringType && b.DeclaringType.IsGenericButNotGenericTypeDefinition()) {
				var t = b;
				b = b.Module.ResolveMethod(b.MetadataToken);
				if (b.IsGenericButNotGenericMethodDefinition())
					b = ((MethodInfo)b).MakeGenericMethod(t.GetGenericArguments());
			}
			bool result = Equals(a.GetCallingConvention(), b) &&
					(DontCompareReturnType || ReturnTypeEquals(a.RetType, b)) &&
					(!CompareMethodParams || Equals(a.Params, b.GetParameters(), b.DeclaringType)) &&
					(!a.Generic || a.GenParamCount == b.GetGenericArguments().Length);

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares methods
		/// </summary>
		/// <param name="a">Method #1</param>
		/// <param name="b">Method #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(MethodBase a, MemberRef b) => Equals(b, a);

		/// <summary>
		/// Compares methods
		/// </summary>
		/// <param name="a">Method #1</param>
		/// <param name="b">Method #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(MemberRef a, MethodBase b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;
			bool result;

			if (!DontProjectWinMDRefs)
				a = WinMDHelpers.ToCLR(a.Module ?? sourceModule, a) ?? a;
			if (b.IsGenericMethod && !b.IsGenericMethodDefinition) {
				// 'a' must be a method ref in a generic type. This comparison must match
				// the MethodSpec vs MethodBase comparison code.
				result = a.IsMethodRef && a.MethodSig.Generic;

				var oldOptions = ClearOptions(SigComparerOptions.CompareMethodFieldDeclaringType);
				SetOptions(SigComparerOptions_DontSubstituteGenericParameters);
				result = result && Equals(a, b.Module.ResolveMethod(b.MetadataToken));
				RestoreOptions(oldOptions);
				result = result && DeclaringTypeEquals(a, b);

				result = result && GenericMethodArgsEquals((int)a.MethodSig.GenParamCount, b.GetGenericArguments());
			}
			else {
				var amSig = a.MethodSig;
				result = Equals_MethodFieldNames(a.Name, b.Name) &&
						amSig is not null &&
						((amSig.Generic && b.IsGenericMethodDefinition && b.IsGenericMethod) ||
						(!amSig.Generic && !b.IsGenericMethodDefinition && !b.IsGenericMethod));

				GenericInstSig git;
				if (CompareMethodFieldDeclaringType && !DontSubstituteGenericParameters && (git = GetGenericInstanceType(a.Class)) is not null) {
					InitializeGenericArguments();
					genericArguments.PushTypeArgs(git.GenericArguments);
					result = result && Equals(amSig, b);
					genericArguments.PopTypeArgs();
				}
				else
					result = result && Equals(amSig, b);

				result = result && (!CompareMethodFieldDeclaringType || Equals(a.Class, b.DeclaringType, b.Module));
			}

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares generic method args, making sure <paramref name="methodGenArgs"/> only
		/// contains <see cref="ElementType.MVar"/>s.
		/// </summary>
		/// <param name="numMethodArgs">Number of generic method args in method #1</param>
		/// <param name="methodGenArgs">Generic method args in method #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		static bool GenericMethodArgsEquals(int numMethodArgs, IList<Type> methodGenArgs) {
			if (numMethodArgs != methodGenArgs.Count)
				return false;
			for (int i = 0; i < numMethodArgs; i++) {
				if (methodGenArgs[i].GetElementType2() != ElementType.MVar)
					return false;
			}
			return true;
		}

		bool Equals(IMemberRefParent a, Type b, Module bModule) {
			// Global methods and fields have their DeclaringType set to null. Assume
			// null always means the global type.
			if (a is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;
			ITypeDefOrRef ita;
			ModuleRef moda;
			MethodDef ma;
			TypeDef td;

			if ((ita = a as ITypeDefOrRef) is not null)
				result = Equals((IType)ita, b);
			else if ((moda = a as ModuleRef) is not null) {
				var omoda = moda.Module;
				result = b is null &&   // b is null => it's the global type
						Equals(moda, bModule) &&
						Equals(omoda?.Assembly, bModule.Assembly);
			}
			else if ((ma = a as MethodDef) is not null)
				result = Equals(ma.DeclaringType, b);
			else if (b is null && (td = a as TypeDef) is not null)
				result = td.IsGlobalModuleType;
			else
				result = false;

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares methods
		/// </summary>
		/// <param name="a">Method #1</param>
		/// <param name="b">Method #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(MethodBase a, MethodSpec b) => Equals(b, a);

		/// <summary>
		/// Compares methods
		/// </summary>
		/// <param name="a">Method #1</param>
		/// <param name="b">Method #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(MethodSpec a, MethodBase b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			// Make sure it's a MethodSpec
			bool result = b.IsGenericMethod && !b.IsGenericMethodDefinition;

			// Don't compare declaring types yet because the resolved method has the wrong
			// declaring type (its declaring type is a generic type def).
			// NOTE: We must not push generic method args when comparing a.Method
			var oldOptions = ClearOptions(SigComparerOptions.CompareMethodFieldDeclaringType);
			SetOptions(SigComparerOptions_DontSubstituteGenericParameters);
			result = result && Equals(a.Method, b.Module.ResolveMethod(b.MetadataToken));
			RestoreOptions(oldOptions);
			result = result && DeclaringTypeEquals(a.Method, b);

			var gim = a.GenericInstMethodSig;
			result = result && gim is not null && Equals(gim.GenericArguments, b.GetGenericArguments(), b.DeclaringType);

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a <c>MethodBase</c>
		/// </summary>
		/// <param name="a">The <c>MethodBase</c></param>
		/// <returns>The hash code</returns>
		public int GetHashCode(MethodBase a) {
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;

			// ***********************************************************************
			// IMPORTANT: This hash code must match the MemberRef/MethodSpec hash code
			// ***********************************************************************
			int hash = GetHashCode_MethodFieldName(a.Name) +
					GetHashCode_MethodSig(a);
			if (CompareMethodFieldDeclaringType)
				hash += GetHashCode(a.DeclaringType);

			recursionCounter.Decrement();
			return hash;
		}

		int GetHashCode_MethodSig(MethodBase a) {
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;
			int hash;

			if (!CompareMethodFieldDeclaringType && a.DeclaringType.IsGenericButNotGenericTypeDefinition()) {
				var t = a;
				a = a.Module.ResolveMethod(a.MetadataToken);
				if (t.IsGenericButNotGenericMethodDefinition())
					a = ((MethodInfo)a).MakeGenericMethod(t.GetGenericArguments());
			}
			hash = GetHashCode_CallingConvention(a.CallingConvention, a.IsGenericMethod) +
					GetHashCode(a.GetParameters(), a.DeclaringType);
			if (!DontCompareReturnType)
				hash += GetHashCode_ReturnType(a);
			if (a.IsGenericMethod)
				hash += GetHashCode_ElementType_MVar(a.GetGenericArguments().Length);

			recursionCounter.Decrement();
			return hash;
		}

		/// <summary>
		/// Gets the hash code of a parameter list
		/// </summary>
		/// <param name="a">The type list</param>
		/// <param name="declaringType">Declaring type of method that owns parameter <paramref name="a"/></param>
		/// <returns>The hash code</returns>
		int GetHashCode(IList<ParameterInfo> a, Type declaringType) {
			//************************************************************************
			// IMPORTANT: This code must match any other GetHashCode(IList<SOME_TYPE>)
			//************************************************************************
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;
			uint hash = 0;
			for (int i = 0; i < a.Count; i++) {
				hash += (uint)GetHashCode(a[i], declaringType);
				hash = (hash << 13) | (hash >> 19);
			}
			recursionCounter.Decrement();
			return (int)hash;
		}

		int GetHashCode_ReturnType(MethodBase a) {
			var mi = a as MethodInfo;
			if (mi is not null)
				return GetHashCode(mi.ReturnParameter, a.DeclaringType);
			return GetHashCode(typeof(void));
		}

		int GetHashCode(ParameterInfo a, Type declaringType) => GetHashCode(a.ParameterType, declaringType);

		/// <summary>
		/// Compares calling conventions
		/// </summary>
		/// <param name="a">Calling convention</param>
		/// <param name="b">Method</param>
		/// <returns></returns>
		static bool Equals(CallingConvention a, MethodBase b) {
			var bc = b.CallingConvention;

			if (((a & CallingConvention.Generic) != 0) != b.IsGenericMethod)
				return false;
			if (((a & CallingConvention.HasThis) != 0) != ((bc & CallingConventions.HasThis) != 0))
				return false;
			if (((a & CallingConvention.ExplicitThis) != 0) != ((bc & CallingConventions.ExplicitThis) != 0))
				return false;

			var cca = a & CallingConvention.Mask;
			switch (bc & CallingConventions.Any) {
			case CallingConventions.Standard:
				if (cca == CallingConvention.VarArg || cca == CallingConvention.NativeVarArg)
					return false;
				break;

			case CallingConventions.VarArgs:
				if (cca != CallingConvention.VarArg && cca != CallingConvention.NativeVarArg)
					return false;
				break;

			case CallingConventions.Any:
			default:
				break;
			}

			return true;
		}

		static int GetHashCode_CallingConvention(CallingConventions a, bool isGeneric) {
			//**************************************************************
			// IMPORTANT: This hash must match the other call conv hash code
			//**************************************************************

			CallingConvention cc = 0;

			if (isGeneric)
				cc |= CallingConvention.Generic;
			if ((a & CallingConventions.HasThis) != 0)
				cc |= CallingConvention.HasThis;
			if ((a & CallingConventions.ExplicitThis) != 0)
				cc |= CallingConvention.ExplicitThis;

			return (int)cc;
		}

		/// <summary>
		/// Compares return types
		/// </summary>
		/// <param name="a">Return type #1</param>
		/// <param name="b">MethodBase</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		bool ReturnTypeEquals(TypeSig a, MethodBase b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;
			var mi = b as MethodInfo;
			if (mi is not null)
				result = Equals(a, mi.ReturnParameter, b.DeclaringType);
			else if (b is ConstructorInfo)
				result = IsSystemVoid(a);
			else
				result = false;

			recursionCounter.Decrement();
			return result;
		}

		static bool IsSystemVoid(TypeSig a) => a.RemovePinnedAndModifiers().GetElementType() == ElementType.Void;

		/// <summary>
		/// Compares parameter lists
		/// </summary>
		/// <param name="a">Type list #1</param>
		/// <param name="b">Type list #2</param>
		/// <param name="declaringType">Declaring type of method that owns parameter <paramref name="b"/></param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		bool Equals(IList<TypeSig> a, IList<ParameterInfo> b, Type declaringType) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;
			bool result;

			if (a.Count != b.Count)
				result = false;
			else {
				int i;
				for (i = 0; i < a.Count; i++) {
					if (!Equals(a[i], b[i], declaringType))
						break;
				}
				result = i == a.Count;
			}

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares parameter types
		/// </summary>
		/// <param name="a">Parameter type #1</param>
		/// <param name="b">Parameter #2</param>
		/// <param name="declaringType">Declaring type of method that owns parameter <paramref name="b"/></param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		bool Equals(TypeSig a, ParameterInfo b, Type declaringType) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result = ModifiersEquals(a, b.GetRequiredCustomModifiers(), b.GetOptionalCustomModifiers(), out var a2) &&
						Equals(a2, b.ParameterType, declaringType);

			recursionCounter.Decrement();
			return result;
		}

		bool ModifiersEquals(TypeSig a, IList<Type> reqMods2, IList<Type> optMods2, out TypeSig aAfterModifiers) {
			aAfterModifiers = a;
			if (!(a is ModifierSig))
				return reqMods2.Count == 0 && optMods2.Count == 0;
			if (!recursionCounter.Increment())
				return false;
			bool result;

			var reqMods1 = new List<ITypeDefOrRef>(reqMods2.Count);
			var optMods1 = new List<ITypeDefOrRef>(optMods2.Count);
			while (true) {
				var modifierSig = aAfterModifiers as ModifierSig;
				if (modifierSig is null)
					break;
				if (modifierSig is CModOptSig)
					optMods1.Add(modifierSig.Modifier);
				else
					reqMods1.Add(modifierSig.Modifier);

				// This can only loop forever if the user created a loop. It's not possible
				// to create a loop with invalid metadata.
				aAfterModifiers = aAfterModifiers.Next;
			}
			optMods1.Reverse();
			reqMods1.Reverse();

			result = reqMods1.Count == reqMods2.Count &&
					optMods1.Count == optMods2.Count &&
					ModifiersEquals(reqMods1, reqMods2) &&
					ModifiersEquals(optMods1, optMods2);

			recursionCounter.Decrement();
			return result;
		}

		bool ModifiersEquals(IList<ITypeDefOrRef> a, IList<Type> b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;
			bool result;

			if (a.Count != b.Count)
				result = false;
			else {
				int i;
				for (i = 0; i < b.Count; i++) {
					if (!Equals(a[i], b[i]))
						break;
				}
				result = i == b.Count;
			}

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares fields
		/// </summary>
		/// <param name="a">Field #1</param>
		/// <param name="b">Field #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(FieldInfo a, IField b) => Equals(b, a);

		/// <summary>
		/// Compares fields
		/// </summary>
		/// <param name="a">Field #1</param>
		/// <param name="b">Field #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(IField a, FieldInfo b) {
			if ((object)a == b)
				return true;
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result;
			FieldDef fa;
			MemberRef ma;

			if ((fa = a as FieldDef) is not null)
				result = Equals(fa, b);
			else if ((ma = a as MemberRef) is not null)
				result = Equals(ma, b);
			else
				result = false;

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares fields
		/// </summary>
		/// <param name="a">Field #1</param>
		/// <param name="b">Field #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(FieldInfo a, FieldDef b) => Equals(b, a);

		/// <summary>
		/// Compares fields
		/// </summary>
		/// <param name="a">Field #1</param>
		/// <param name="b">Field #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(FieldDef a, FieldInfo b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result = Equals_MethodFieldNames(a.Name, b.Name) &&
					Equals(a.FieldSig, b) &&
					(!CompareMethodFieldDeclaringType || Equals(a.DeclaringType, b.DeclaringType));

			recursionCounter.Decrement();
			return result;
		}

		bool Equals(FieldSig a, FieldInfo b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			if (!CompareMethodFieldDeclaringType && b.DeclaringType.IsGenericButNotGenericTypeDefinition())
				b = b.Module.ResolveField(b.MetadataToken);
			bool result = ModifiersEquals(a.Type, b.GetRequiredCustomModifiers(), b.GetOptionalCustomModifiers(), out var a2) &&
					Equals(a2, b.FieldType, b.DeclaringType);

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Compares fields
		/// </summary>
		/// <param name="a">Field #1</param>
		/// <param name="b">Field #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(FieldInfo a, MemberRef b) => Equals(b, a);

		/// <summary>
		/// Compares fields
		/// </summary>
		/// <param name="a">Field #1</param>
		/// <param name="b">Field #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(MemberRef a, FieldInfo b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result = Equals_MethodFieldNames(a.Name, b.Name);

			GenericInstSig git;
			if (CompareMethodFieldDeclaringType && !DontSubstituteGenericParameters && (git = GetGenericInstanceType(a.Class)) is not null) {
				InitializeGenericArguments();
				genericArguments.PushTypeArgs(git.GenericArguments);
				result = result && Equals(a.FieldSig, b);
				genericArguments.PopTypeArgs();
			}
			else
				result = result && Equals(a.FieldSig, b);

			result = result && (!CompareMethodFieldDeclaringType || Equals(a.Class, b.DeclaringType, b.Module));

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a field
		/// </summary>
		/// <param name="a">The field</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(FieldInfo a) {
			// ************************************************************
			// IMPORTANT: This hash code must match the MemberRef hash code
			// ************************************************************
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;

			int hash = GetHashCode_MethodFieldName(a.Name) +
					GetHashCode_FieldSig(a);
			if (CompareMethodFieldDeclaringType)
				hash += GetHashCode(a.DeclaringType);

			recursionCounter.Decrement();
			return hash;
		}

		int GetHashCode_FieldSig(FieldInfo a) {
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;
			int hash;

			if (!CompareMethodFieldDeclaringType && a.DeclaringType.IsGenericButNotGenericTypeDefinition())
				a = a.Module.ResolveField(a.MetadataToken);
			hash = GetHashCode_CallingConvention(0, false) + GetHashCode(a.FieldType, a.DeclaringType);

			recursionCounter.Decrement();
			return hash;
		}

		/// <summary>
		/// Compares properties
		/// </summary>
		/// <param name="a">Property #1</param>
		/// <param name="b">Property #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(PropertyDef a, PropertyInfo b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result = Equals_PropertyNames(a.Name, b.Name) &&
					Equals(a.PropertySig, b) &&
					(!ComparePropertyDeclaringType || Equals(a.DeclaringType, b.DeclaringType));

			recursionCounter.Decrement();
			return result;
		}

		bool Equals(PropertySig a, PropertyInfo b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result = ModifiersEquals(a.RetType, b.GetRequiredCustomModifiers(), b.GetOptionalCustomModifiers(), out var a2) &&
					Equals(a2, b.PropertyType, b.DeclaringType);

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of a property
		/// </summary>
		/// <param name="a">The property</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(PropertyInfo a) {
			// **************************************************************
			// IMPORTANT: This hash code must match the PropertyDef hash code
			// **************************************************************
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;

			int hash = GetHashCode_PropertyName(a.Name) +
					GetHashCode(a.PropertyType, a.DeclaringType);
			if (ComparePropertyDeclaringType)
				hash += GetHashCode(a.DeclaringType);

			recursionCounter.Decrement();
			return hash;
		}

		/// <summary>
		/// Compares events
		/// </summary>
		/// <param name="a">Event #1</param>
		/// <param name="b">Event #2</param>
		/// <returns><c>true</c> if same, <c>false</c> otherwise</returns>
		public bool Equals(EventDef a, EventInfo b) {
			if ((object)a == (object)b)
				return true;    // both are null
			if (a is null || b is null)
				return false;
			if (!recursionCounter.Increment())
				return false;

			bool result = Equals_EventNames(a.Name, b.Name) &&
					Equals(a.EventType, b.EventHandlerType, b.DeclaringType) &&
					(!CompareEventDeclaringType || Equals(a.DeclaringType, b.DeclaringType));

			recursionCounter.Decrement();
			return result;
		}

		/// <summary>
		/// Gets the hash code of an event
		/// </summary>
		/// <param name="a">The event</param>
		/// <returns>The hash code</returns>
		public int GetHashCode(EventInfo a) {
			// ***********************************************************
			// IMPORTANT: This hash code must match the EventDef hash code
			// ***********************************************************
			if (a is null)
				return 0;
			if (!recursionCounter.Increment())
				return 0;

			int hash = GetHashCode_EventName(a.Name) +
					GetHashCode(a.EventHandlerType, a.DeclaringType);
			if (CompareEventDeclaringType)
				hash += GetHashCode(a.DeclaringType);

			recursionCounter.Decrement();
			return hash;
		}

		/// <inheritdoc/>
		public override string ToString() => $"{recursionCounter} - {options}";

		static bool InSameModule(IOwnerModule a, IOwnerModule b) => a.Module is { } module && module == b.Module;
	}
}
