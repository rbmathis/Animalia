using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Nesomys;

/// <summary>
/// Abstract class for Nesomys (genus).
/// NCBI TaxId: 52811
/// </summary>
public abstract class Nesomys : Nesomyidae, INesomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52811;

    /// <inheritdoc />
    public virtual string GenusName => "Nesomys";

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
