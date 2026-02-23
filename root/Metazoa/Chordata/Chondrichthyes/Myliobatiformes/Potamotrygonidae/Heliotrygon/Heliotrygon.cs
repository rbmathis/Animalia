using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae.Heliotrygon;

/// <summary>
/// Abstract class for Heliotrygon (genus).
/// NCBI TaxId: 1090083
/// </summary>
public abstract class Heliotrygon : Potamotrygonidae, IHeliotrygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heliotrygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1090083;

    /// <inheritdoc />
    public virtual string GenusName => "Heliotrygon";

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
