using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Neopteryx;

/// <summary>
/// Abstract class for Neopteryx (genus).
/// NCBI TaxId: 2747555
/// </summary>
public abstract class Neopteryx : Pteropodidae, INeopteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neopteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2747555;

    /// <inheritdoc />
    public virtual string GenusName => "Neopteryx";

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
