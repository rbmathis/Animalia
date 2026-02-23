using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae.Potamotrygon;

/// <summary>
/// Abstract class for Potamotrygon (genus).
/// NCBI TaxId: 86372
/// </summary>
public abstract class Potamotrygon : Potamotrygonidae, IPotamotrygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Potamotrygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86372;

    /// <inheritdoc />
    public virtual string GenusName => "Potamotrygon";

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
