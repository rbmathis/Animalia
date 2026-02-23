using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Geomyidae.Thomomys;

/// <summary>
/// Abstract class for Thomomys (genus).
/// NCBI TaxId: 10011
/// </summary>
public abstract class Thomomys : Geomyidae, IThomomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thomomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10011;

    /// <inheritdoc />
    public virtual string GenusName => "Thomomys";

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
