using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Pteralopex;

/// <summary>
/// Abstract class for Pteralopex (genus).
/// NCBI TaxId: 58080
/// </summary>
public abstract class Pteralopex : Pteropodidae, IPteralopex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pteralopex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58080;

    /// <inheritdoc />
    public virtual string GenusName => "Pteralopex";

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
