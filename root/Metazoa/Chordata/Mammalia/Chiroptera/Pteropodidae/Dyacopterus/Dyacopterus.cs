using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Dyacopterus;

/// <summary>
/// Abstract class for Dyacopterus (genus).
/// NCBI TaxId: 326080
/// </summary>
public abstract class Dyacopterus : Pteropodidae, IDyacopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dyacopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 326080;

    /// <inheritdoc />
    public virtual string GenusName => "Dyacopterus";

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
