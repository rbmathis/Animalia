using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Eptesicus;

/// <summary>
/// Abstract class for Eptesicus (genus).
/// NCBI TaxId: 3371007
/// </summary>
public abstract class Eptesicus : Vespertilionidae, IEptesicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eptesicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3371007;

    /// <inheritdoc />
    public virtual string GenusName => "Eptesicus";

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
