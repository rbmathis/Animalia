using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Chironax;

/// <summary>
/// Abstract class for Chironax (genus).
/// NCBI TaxId: 170235
/// </summary>
public abstract class Chironax : Pteropodidae, IChironax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chironax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 170235;

    /// <inheritdoc />
    public virtual string GenusName => "Chironax";

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
