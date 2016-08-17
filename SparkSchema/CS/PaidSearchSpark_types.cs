



//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Tool     : bondc, Version=3.0.1, Build=bond-git.retail.directory
//     Template : Microsoft.Bond.Rules.dll#Rules_Bond_CSharp.tt
//     File     : PaidSearchSpark_types.cs
//
//     Changes to this file may cause incorrect behavior and will be lost when
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using global::Microsoft.Bond;
using global::System;
using global::System.Collections;
using global::System.Collections.Generic;
using global::System.Text;

namespace SparkSchema
{

/// <summary>
/// PaidSearchSpark
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("bondc.exe", null)]
public partial class PaidSearchSpark : IBondSerializable, IGenericSerializer
{
    //
    // Fields
    //

    // 1: Optional Microsoft.Bond.GUID UETUserId
    private global::Microsoft.Bond.GUID m_UETUserId;

    // 2: Optional SparkSchema.UETUserIdTypeSpark UetUserIdType
    private global::SparkSchema.UETUserIdTypeSpark m_UetUserIdType;

    // 3: Optional vector<SparkSchema.UserAdActivityDetailSpark> UserAdActivities
    private List<global::SparkSchema.UserAdActivityDetailSpark> m_UserAdActivities;

    // 4: Optional int64 ClickDateTime
    private Int64 m_ClickDateTime;

    // 5: Optional SparkSchema.SearchClickDetailSpark SeaClickDetail
    private global::SparkSchema.SearchClickDetailSpark m_SeaClickDetail;

    /// <summary>
    /// UETUserId
    /// </summary>
    public global::Microsoft.Bond.GUID UETUserId
    {
        get { return this.m_UETUserId; }
        set { this.m_UETUserId = value; }
    }

    /// <summary>
    /// UetUserIdType
    /// </summary>
    public global::SparkSchema.UETUserIdTypeSpark UetUserIdType
    {
        get { return this.m_UetUserIdType; }
        set { this.m_UetUserIdType = value; }
    }

    /// <summary>
    /// UserAdActivities
    /// </summary>
    public List<global::SparkSchema.UserAdActivityDetailSpark> UserAdActivities
    {
        get { return this.m_UserAdActivities; }
        set { this.m_UserAdActivities = value; }
    }

    /// <summary>
    /// ClickDateTime
    /// </summary>
    public Int64 ClickDateTime
    {
        get { return this.m_ClickDateTime; }
        set { this.m_ClickDateTime = value; }
    }

    /// <summary>
    /// SeaClickDetail
    /// </summary>
    public global::SparkSchema.SearchClickDetailSpark SeaClickDetail
    {
        get { return this.m_SeaClickDetail; }
        set { this.m_SeaClickDetail = value; }
    }

    /// <summary>
    /// GetFullyQualifiedName
    /// </summary>
    public static string GetFullyQualifiedName()
    {
        return __internal.sc_structQualifiedName;
    }

    /// <summary>
    /// Meta schema.
    /// </summary>
    private static class Schema
    {
        public static readonly Metadata meta = new Metadata();
        public static readonly Metadata UETUserId_meta = new Metadata();
        public static readonly Metadata UetUserIdType_meta = new Metadata();
        public static readonly Metadata UserAdActivities_meta = new Metadata();
        public static readonly Metadata ClickDateTime_meta = new Metadata();
        public static readonly Metadata SeaClickDetail_meta = new Metadata();

        static Schema()
        {
            StringBuilder runtimeName = new StringBuilder();
            runtimeName.Append("PaidSearchSpark");
 
            meta.name = runtimeName.ToString();
            meta.qualified_name = "SparkSchema." + meta.name;


            // UETUserId
            UETUserId_meta.name = "UETUserId";
            UETUserId_meta.modifier = global::Microsoft.Bond.Modifier.Optional;

            // UetUserIdType
            UetUserIdType_meta.name = "UetUserIdType";
            UetUserIdType_meta.modifier = global::Microsoft.Bond.Modifier.Optional;

            UetUserIdType_meta.default_value.int_value = Convert.ToInt64(global::SparkSchema.UETUserIdTypeSpark.UAIPID);

            // UserAdActivities
            UserAdActivities_meta.name = "UserAdActivities";
            UserAdActivities_meta.modifier = global::Microsoft.Bond.Modifier.Optional;

            // ClickDateTime
            ClickDateTime_meta.name = "ClickDateTime";
            ClickDateTime_meta.modifier = global::Microsoft.Bond.Modifier.Optional;

            ClickDateTime_meta.default_value.int_value = 0;

            // SeaClickDetail
            SeaClickDetail_meta.name = "SeaClickDetail";
            SeaClickDetail_meta.modifier = global::Microsoft.Bond.Modifier.Optional;
        }   // ~static Schema()

    }   // ~Schema


    private static class __ordinals
    {
        public const int UETUserId = 1;
        public const int UetUserIdType = 2;
        public const int UserAdActivities = 3;
        public const int ClickDateTime = 4;
        public const int SeaClickDetail = 5;
    }   // ~__ordinals


    private static class __internal
    {

        public static readonly String sc_structName = Schema.meta.name;
        public static readonly String sc_structQualifiedName = Schema.meta.qualified_name;

        public const String s_UETUserId = "UETUserId";
        public const String s_UetUserIdType = "UetUserIdType";
        public const String s_UserAdActivities = "UserAdActivities";
        public const String s_ClickDateTime = "ClickDateTime";
        public const String s_SeaClickDetail = "SeaClickDetail";
    }   // ~__internal

    /// <summary>
    /// Constructor
    /// </summary>
    public PaidSearchSpark()
    {
        Reset();
    }

    /// <summary>
    /// Reset instance and re-initialize the members.
    /// </summary>
    public virtual void Reset()
    {
        Reset(__internal.sc_structName, __internal.sc_structQualifiedName);
    }

    /// <summary>
    /// Reset
    /// </summary>
    protected  void Reset(string name, string qualifiedName)
    {
        
        ResetImpl(name, qualifiedName);
    }

    private void ResetImpl(string name, string qualifiedName)
    {
        m_UETUserId = new global::Microsoft.Bond.GUID();
        m_UetUserIdType = global::SparkSchema.UETUserIdTypeSpark.UAIPID;
        if (m_UserAdActivities == null)
        {
            m_UserAdActivities = new List<global::SparkSchema.UserAdActivityDetailSpark>();
        }
        else
        {
            m_UserAdActivities.Clear();
        }
        m_ClickDateTime = 0;
        m_SeaClickDetail = new global::SparkSchema.SearchClickDetailSpark();
    } // ResetImpl()

    /// <summary>
    /// Clone
    /// </summary>
    public virtual IBondSerializable Clone()
    {
        global::SparkSchema.PaidSearchSpark cloned = new global::SparkSchema.PaidSearchSpark();
        CopyTo(cloned);
        return cloned;
    }

    /// <summary>
    /// CopyTo
    /// </summary>
    public void CopyTo(global::SparkSchema.PaidSearchSpark that)
    {
        if (that == null)
        {
            throw new  ArgumentNullException("that");
        }
        
        // 1: Microsoft.Bond.GUID UETUserId
        that.UETUserId = (this.UETUserId == null ? null : (global::Microsoft.Bond.GUID)this.UETUserId.Clone());
        // 2: SparkSchema.UETUserIdTypeSpark UetUserIdType
        that.UetUserIdType = this.UetUserIdType;
        // 3: vector<SparkSchema.UserAdActivityDetailSpark> UserAdActivities
        if (this.UserAdActivities != null)
        {
            if (that.UserAdActivities == null)
            {
                that.UserAdActivities = new List<global::SparkSchema.UserAdActivityDetailSpark>();
            }
            else
            {
                that.UserAdActivities.Clear();
            }
            foreach (var iter1 in this.UserAdActivities)
            {
                global::SparkSchema.UserAdActivityDetailSpark tmpItem2 = default(global::SparkSchema.UserAdActivityDetailSpark);
                tmpItem2 = (iter1 == null ? null : (global::SparkSchema.UserAdActivityDetailSpark)iter1.Clone());
                that.UserAdActivities.Add(tmpItem2);
            }
        }
        else
        {
            that.UserAdActivities = null;
        }
        // 4: int64 ClickDateTime
        that.ClickDateTime = this.ClickDateTime;
        // 5: SparkSchema.SearchClickDetailSpark SeaClickDetail
        that.SeaClickDetail = (this.SeaClickDetail == null ? null : (global::SparkSchema.SearchClickDetailSpark)this.SeaClickDetail.Clone());
    }    // ~CopyTo


    /// <summary>
    /// Unmarshal
    /// </summary>
    public virtual void Unmarshal(System.IO.Stream input)
    {
        global::Microsoft.Bond.Marshaler.Unmarshal(input, this);
    }

    /// <summary>
    /// Unmarshal
    /// </summary>
    public virtual void Unmarshal(System.IO.Stream input, IBondSerializable schema)
    {
        global::Microsoft.Bond.Marshaler.Unmarshal(input, schema as SchemaDef, this);
    }

    /// <summary>
    /// Read
    /// </summary>
    public virtual void Read(global::Microsoft.Bond.IProtocolReader reader)
    {
        if (!reader.HasCapability(global::Microsoft.Bond.Protocol.Tagged))
        {
            ReadUntagged(reader);
        }
        else
        {
            bool isPartialStruct;

            if (reader.HasCapability((global::Microsoft.Bond.Protocol)global::Microsoft.Bond.ProtocolInternal.CloneableBonded))
            {
                reader = reader.Clone();
            }
            
            Read(reader, out isPartialStruct);
            
            if (isPartialStruct)
            {
                global::Microsoft.Bond.ReadHelper.SkipPartialStruct(reader);
            }
        }
    }

    /// <summary>
    /// Read
    /// </summary>
    public virtual void Read(global::Microsoft.Bond.IProtocolReader reader, IBondSerializable schema)
    {
        Read(ProtocolHelper.CreateReader(reader, schema));
    }

    /// <summary>
    /// ReadUntagged
    /// </summary>
    protected  void ReadUntagged(global::Microsoft.Bond.IProtocolReader reader)
    {
        bool canOmitFields = reader.HasCapability(global::Microsoft.Bond.Protocol.CanOmitFields);
        Reset();
        

        reader.ReadStructBegin();

        if (!canOmitFields || !reader.ReadFieldOmitted())
        {
            this.UETUserId.Read(reader);
        }

        if (!canOmitFields || !reader.ReadFieldOmitted())
        {
            this.UetUserIdType = (global::SparkSchema.UETUserIdTypeSpark)reader.ReadInt32();
        }

        if (!canOmitFields || !reader.ReadFieldOmitted())
        {
            this.ReadField_impl_UserAdActivities(reader, global::Microsoft.Bond.BondDataType.BT_LIST);
        }

        if (!canOmitFields || !reader.ReadFieldOmitted())
        {
            this.ClickDateTime = reader.ReadInt64();
        }

        if (!canOmitFields || !reader.ReadFieldOmitted())
        {
            this.SeaClickDetail.Read(reader);
        }
        reader.ReadStructEnd();
    }   // ~ReadUntagged()


    /// <summary>
    /// Read
    /// </summary>
    protected  void Read(global::Microsoft.Bond.IProtocolReader reader, out bool isPartialStruct)
    {
        Reset();

        reader.ReadStructBegin(true);
        
        while (true)
        {
            BondDataType type = BondDataType.BT_STOP;
            UInt16 id = UInt16.MaxValue;

            reader.ReadFieldBegin(out type, out id);

            if (type == BondDataType.BT_STOP || type == BondDataType.BT_STOP_BASE)
            {
                isPartialStruct = (type == BondDataType.BT_STOP_BASE);
                break;
            }

            switch (id)
            {
                case __ordinals.UETUserId:  // id=1
                    global::Microsoft.Bond.ReadHelper.ValidateType(type, global::Microsoft.Bond.BondDataType.BT_STRUCT);
                    this.UETUserId.Read(reader);
                    break;
                case __ordinals.UetUserIdType:  // id=2
                    this.UetUserIdType = (global::SparkSchema.UETUserIdTypeSpark)global::Microsoft.Bond.ReadHelper.ReadInt32(reader, type);
                    break;
                case __ordinals.UserAdActivities:  // id=3
                    this.ReadField_impl_UserAdActivities(reader, type);
                    break;
                case __ordinals.ClickDateTime:  // id=4
                    this.ClickDateTime = global::Microsoft.Bond.ReadHelper.ReadInt64(reader, type);
                    break;
                case __ordinals.SeaClickDetail:  // id=5
                    global::Microsoft.Bond.ReadHelper.ValidateType(type, global::Microsoft.Bond.BondDataType.BT_STRUCT);
                    this.SeaClickDetail.Read(reader);
                    break;
                default:
                    reader.Skip(type);
                    break;
            } // ~switch

            reader.ReadFieldEnd();

        } // ~while

        reader.ReadStructEnd();

    }   // ~Read()


    private void ReadField_impl_UserAdActivities(global::Microsoft.Bond.IProtocolReader reader, global::Microsoft.Bond.BondDataType typeInPayload)
    {
        global::Microsoft.Bond.ReadHelper.ValidateType(typeInPayload, global::Microsoft.Bond.BondDataType.BT_LIST);
 
        BondDataType elemType1;
        UInt32 count2;
    
        reader.ReadContainerBegin(out count2, out elemType1);
        global::Microsoft.Bond.ReadHelper.ValidateType(elemType1, global::Microsoft.Bond.BondDataType.BT_STRUCT);
        if (this.m_UserAdActivities.Capacity < count2)
        {
            this.m_UserAdActivities.Capacity = (int)count2;
        }
    
        for (UInt32 i4 = 0; i4 < count2; i4++)
        {
            global::SparkSchema.UserAdActivityDetailSpark element3 = new global::SparkSchema.UserAdActivityDetailSpark();
             
            ReadHelper.ReadStruct(reader, element3, elemType1);
            this.m_UserAdActivities.Add(element3);
        }
    
        reader.ReadContainerEnd();
    } // ReadField_impl_UserAdActivities


    /// <summary>
    /// Marshal
    /// </summary>
    virtual public void Marshal(IProtocolWriter writer)
    {
        global::Microsoft.Bond.Marshaler.Marshal(this, writer);
    }

    /// <summary>
    /// Write
    /// </summary>
    virtual public void Write(global::Microsoft.Bond.IProtocolWriter writer)
    {
        Write(writer, true);
    }

    /// <summary>
    /// Write
    /// </summary>
    public void Write(global::Microsoft.Bond.IProtocolWriter writer, bool isTopLevel)
    {
        global::Microsoft.Bond.IProtocolWriter pass0; 
        
        if (isTopLevel && (pass0 = writer.GetPass0Writer()) != null)
        {
            WriteInternal(pass0, isTopLevel);
            WriteInternal(writer, isTopLevel);
            writer.EndDoublePass();
        }
        else
        {
            WriteInternal(writer, isTopLevel);
        }
    }   // ~Write()

    /// <summary>
    /// Write
    /// </summary>
    virtual public void Write(global::Microsoft.Bond.IProtocolWriter writer, System.Type type)
    {
        if (type == typeof(PaidSearchSpark))
        {
            Write(writer, true);
        }
    }

    /// <summary>
    /// WriteInternal
    /// </summary>
    protected void WriteInternal(global::Microsoft.Bond.IProtocolWriter writer, bool isTopLevel)
    {
	                

        bool writeAllFields = !writer.MayOmitFields;

        writer.WriteStructBegin(Schema.meta, !isTopLevel, true);

        writer.WriteFieldBegin(global::Microsoft.Bond.BondDataType.BT_STRUCT, __ordinals.UETUserId, Schema.UETUserId_meta);
            m_UETUserId.Write(writer, true);
        writer.WriteFieldEnd();
        if (writeAllFields || (!Schema.UetUserIdType_meta.default_value.Equals(Convert.ToInt32(m_UetUserIdType))))
        {
            writer.WriteFieldBegin(global::Microsoft.Bond.BondDataType.BT_INT32, __ordinals.UetUserIdType, Schema.UetUserIdType_meta);
                writer.WriteInt32((Int32)m_UetUserIdType);
            writer.WriteFieldEnd();
        }
        else
        {
            writer.WriteFieldOmitted(global::Microsoft.Bond.BondDataType.BT_INT32, __ordinals.UetUserIdType, Schema.UetUserIdType_meta);
        }

        UInt32 count1 = ((UInt32)m_UserAdActivities.Count);
        if (writeAllFields || count1 != 0)
        {
            writer.WriteFieldBegin(global::Microsoft.Bond.BondDataType.BT_LIST, __ordinals.UserAdActivities, Schema.UserAdActivities_meta);
                writer.WriteContainerBegin(count1, global::Microsoft.Bond.BondDataType.BT_STRUCT);
            for (int idx2 = 0; idx2 < count1; idx2++)
            {
                    m_UserAdActivities[idx2].Write(writer, true);
            }
            writer.WriteContainerEnd();
            writer.WriteFieldEnd();
        }
        else
        {
            writer.WriteFieldOmitted(global::Microsoft.Bond.BondDataType.BT_LIST, __ordinals.UserAdActivities, Schema.UserAdActivities_meta);
        }

        if (writeAllFields || (!Schema.ClickDateTime_meta.default_value.Equals(m_ClickDateTime)))
        {
            writer.WriteFieldBegin(global::Microsoft.Bond.BondDataType.BT_INT64, __ordinals.ClickDateTime, Schema.ClickDateTime_meta);
                writer.WriteInt64(m_ClickDateTime);
            writer.WriteFieldEnd();
        }
        else
        {
            writer.WriteFieldOmitted(global::Microsoft.Bond.BondDataType.BT_INT64, __ordinals.ClickDateTime, Schema.ClickDateTime_meta);
        }

        writer.WriteFieldBegin(global::Microsoft.Bond.BondDataType.BT_STRUCT, __ordinals.SeaClickDetail, Schema.SeaClickDetail_meta);
            m_SeaClickDetail.Write(writer, true);
        writer.WriteFieldEnd();
        writer.WriteStructEnd(!isTopLevel);
    }   // ~Write()

    private static volatile global::Microsoft.Bond.SchemaDef __schema;

    /// <summary>
    /// GetSchema
    /// </summary>
    public virtual IBondSerializable GetSchema()
    {
        return GetRuntimeSchema();
    }

    /// <summary>
    /// GetRuntimeSchema
    /// </summary>
    static public global::Microsoft.Bond.SchemaDef GetRuntimeSchema()
    {
        if (__schema == null)
        {
            var schema = new global::Microsoft.Bond.SchemaDef();
            schema.root = GetTypeDef(schema);
            __schema = schema;
        }
        return __schema;
    }

    /// <summary>
    /// GetTypeDef
    /// </summary>
    static public global::Microsoft.Bond.TypeDef GetTypeDef(global::Microsoft.Bond.SchemaDef schema)
    {
        global::Microsoft.Bond.TypeDef type = new global::Microsoft.Bond.TypeDef();
        type.id = global::Microsoft.Bond.BondDataType.BT_STRUCT;
        type.struct_def = GetStructDef(schema);
        return type;
    }

    /// <summary>
    /// GetTypeDef
    /// </summary>
    static protected UInt16 GetStructDef(global::Microsoft.Bond.SchemaDef schema)
    {
        UInt16 pos;

        for(pos = 0; pos < schema.structs.Count; pos++)
        {
            if (schema.structs[pos].metadata.qualified_name == __internal.sc_structQualifiedName)
            {
                return pos;
            }
        }
        // pos == schema.structs.Count

        global::Microsoft.Bond.StructDef structDef = new global::Microsoft.Bond.StructDef();
        structDef.metadata.name = __internal.sc_structName;
        structDef.metadata.qualified_name = __internal.sc_structQualifiedName;
        schema.structs.Add(structDef);

        global::Microsoft.Bond.FieldDef field;


        field = new global::Microsoft.Bond.FieldDef();
        field.id = 1;
        field.metadata.name="UETUserId";
        field.metadata.modifier = global::Microsoft.Bond.Modifier.Optional;
        field.metadata.default_value.nothing = false;

        field.type = global::Microsoft.Bond.GUID.GetTypeDef(schema);

        structDef.fields.Add(field);

        field = new global::Microsoft.Bond.FieldDef();
        field.id = 2;
        field.metadata.name="UetUserIdType";
        field.metadata.modifier = global::Microsoft.Bond.Modifier.Optional;
        field.metadata.default_value.nothing = false;

        field.metadata.default_value.int_value = Convert.ToInt64(global::SparkSchema.UETUserIdTypeSpark.UAIPID);
        field.type.id = global::Microsoft.Bond.BondDataType.BT_INT32;

        structDef.fields.Add(field);

        field = new global::Microsoft.Bond.FieldDef();
        field.id = 3;
        field.metadata.name="UserAdActivities";
        field.metadata.modifier = global::Microsoft.Bond.Modifier.Optional;
        field.metadata.default_value.nothing = false;

        field.type.id = global::Microsoft.Bond.BondDataType.BT_LIST;
        field.type.element = new global::Microsoft.Bond.TypeDef();
        field.type.element = global::SparkSchema.UserAdActivityDetailSpark.GetTypeDef(schema);

        structDef.fields.Add(field);

        field = new global::Microsoft.Bond.FieldDef();
        field.id = 4;
        field.metadata.name="ClickDateTime";
        field.metadata.modifier = global::Microsoft.Bond.Modifier.Optional;
        field.metadata.default_value.nothing = false;

        field.metadata.default_value.int_value = 0;
        field.type.id = global::Microsoft.Bond.BondDataType.BT_INT64;

        structDef.fields.Add(field);

        field = new global::Microsoft.Bond.FieldDef();
        field.id = 5;
        field.metadata.name="SeaClickDetail";
        field.metadata.modifier = global::Microsoft.Bond.Modifier.Optional;
        field.metadata.default_value.nothing = false;

        field.type = global::SparkSchema.SearchClickDetailSpark.GetTypeDef(schema);

        structDef.fields.Add(field);

        return pos;
    }
 
    /// <summary>
    /// MemberwiseCompare
    /// </summary>
    public virtual bool MemberwiseCompare(object obj)
    {
        if (obj == null)
        {
            return false;
        }
        
        PaidSearchSpark that = obj as PaidSearchSpark;
        if (that == null)
        {
            return false;
        }
        
        return this.MemberwiseCompare(that);
    }
    
    /// <summary>
    /// MemberwiseCompare
    /// </summary>
    public bool MemberwiseCompare(PaidSearchSpark other)
    {
        if (!MemberwiseCompareQuick(other))
        {
            return false;
        }
        
        return MemberwiseCompareDeep(other);
    }
    

    /// <summary>
    /// MemberwiseCompareQuick
    /// </summary>
    protected bool MemberwiseCompareQuick(PaidSearchSpark that)
    {
        bool equals = true;
        
        equals = equals && ((this.UetUserIdType == that.UetUserIdType));
        equals = equals && ((this.UserAdActivities == null) == (that.UserAdActivities == null));
        equals = equals && ((this.UserAdActivities == null) ? true : (this.UserAdActivities.Count == that.UserAdActivities.Count));
        equals = equals && ((this.ClickDateTime == that.ClickDateTime));
        return equals;
    }    // ~MemberwiseCompareQuick
    
    /// <summary>
    /// MemberwiseCompareDeep
    /// </summary>
    protected bool MemberwiseCompareDeep(PaidSearchSpark that)
    {
        bool equals = true;
        
        equals = equals && (this.UETUserId == null ? true : this.UETUserId.MemberwiseCompare(that.UETUserId));
        if (equals && this.UserAdActivities != null && this.UserAdActivities.Count != 0)
        {
            var enum_1_1 = this.UserAdActivities.GetEnumerator();
            var enum_2_2 = that.UserAdActivities.GetEnumerator();
            while (enum_1_1.MoveNext() && enum_2_2.MoveNext())
            {
                    equals = equals && ((enum_1_1.Current == null) == (enum_2_2.Current == null));
                equals = equals && (enum_1_1.Current == null ? true : enum_1_1.Current.MemberwiseCompare(enum_2_2.Current));
                if (!equals)
                {
                    break;
                }
            }
        }
        equals = equals && (this.SeaClickDetail == null ? true : this.SeaClickDetail.MemberwiseCompare(that.SeaClickDetail));
        return equals;
    }    // ~MemberwiseCompareDeep
    
    /// <summary>
    /// ToString
    /// </summary>
    public override string ToString()
    {
        return ToString(false, '\n');
    }

    /// <summary>
    /// ToString
    /// </summary>
    public  string ToString(bool valuesOnly, char separator)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
   
        if (!valuesOnly)
        {
            sb.AppendFormat("{0}{1}{2}{1}", base.ToString(), separator, __internal.sc_structName);
        }
        
        string format = valuesOnly ? "{1}{2}" : "{0} = {1}{2}";
        sb.AppendFormat(format, __internal.s_UETUserId, this.UETUserId, separator);
        sb.AppendFormat(format, __internal.s_UetUserIdType, this.UetUserIdType, separator);
        sb.AppendFormat(format, __internal.s_UserAdActivities, DumpList(this.UserAdActivities), separator);
        sb.AppendFormat(format, __internal.s_ClickDateTime, this.ClickDateTime, separator);
        sb.AppendFormat(format, __internal.s_SeaClickDetail, this.SeaClickDetail, separator);
        
        return sb.ToString();
    } // ToString()

    private string DumpList<T_DumpList_Type>(IEnumerable<T_DumpList_Type> list)
    {
        if (list == null)
        {
            return "-";
        }
        
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        
        bool isFirst = true;
        foreach (var item in list)
        {
            if (!isFirst)
            {
                sb.Append(';');
            }
            
            sb.Append(item.ToString());
            isFirst = false;
        }
        
        return sb.ToString();
    }
}; // class PaidSearchSpark
} // namespace SparkSchema