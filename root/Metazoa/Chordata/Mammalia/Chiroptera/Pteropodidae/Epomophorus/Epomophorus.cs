using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Epomophorus;

/// <summary>
/// Abstract class for Epomophorus (genus).
/// NCBI TaxId: 58066
/// </summary>
public abstract class Epomophorus : Pteropodidae, IEpomophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Epomophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58066;

    /// <inheritdoc />
    public virtual string GenusName => "Epomophorus";

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
