using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae.Paratrygon;

/// <summary>
/// Abstract class for Paratrygon (genus).
/// NCBI TaxId: 86368
/// </summary>
public abstract class Paratrygon : Potamotrygonidae, IParatrygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paratrygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86368;

    /// <inheritdoc />
    public virtual string GenusName => "Paratrygon";

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
