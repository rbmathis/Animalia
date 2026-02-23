using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Murina;

/// <summary>
/// Abstract class for Murina (genus).
/// NCBI TaxId: 59488
/// </summary>
public abstract class Murina : Vespertilionidae, IMurina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Murina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59488;

    /// <inheritdoc />
    public virtual string GenusName => "Murina";

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
