using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Perognathus;

/// <summary>
/// Abstract class for Perognathus (genus).
/// NCBI TaxId: 37442
/// </summary>
public abstract class Perognathus : Heteromyidae, IPerognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Perognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37442;

    /// <inheritdoc />
    public virtual string GenusName => "Perognathus";

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
