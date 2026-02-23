using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Potamotrygonidae.Plesiotrygon;

/// <summary>
/// Abstract class for Plesiotrygon (genus).
/// NCBI TaxId: 86370
/// </summary>
public abstract class Plesiotrygon : Potamotrygonidae, IPlesiotrygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plesiotrygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86370;

    /// <inheritdoc />
    public virtual string GenusName => "Plesiotrygon";

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
