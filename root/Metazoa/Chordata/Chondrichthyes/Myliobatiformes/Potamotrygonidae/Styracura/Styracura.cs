using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae.Styracura;

/// <summary>
/// Abstract class for Styracura (genus).
/// NCBI TaxId: 2034275
/// </summary>
public abstract class Styracura : Potamotrygonidae, IStyracura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Styracura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2034275;

    /// <inheritdoc />
    public virtual string GenusName => "Styracura";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
