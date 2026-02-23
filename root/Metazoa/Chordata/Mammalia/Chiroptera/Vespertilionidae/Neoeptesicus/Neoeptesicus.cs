using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Neoeptesicus;

/// <summary>
/// Abstract class for Neoeptesicus (genus).
/// NCBI TaxId: 3371080
/// </summary>
public abstract class Neoeptesicus : Vespertilionidae, INeoeptesicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoeptesicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3371080;

    /// <inheritdoc />
    public virtual string GenusName => "Neoeptesicus";

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
