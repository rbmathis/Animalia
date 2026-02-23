using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Aproteles;

/// <summary>
/// Abstract class for Aproteles (genus).
/// NCBI TaxId: 58058
/// </summary>
public abstract class Aproteles : Pteropodidae, IAproteles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aproteles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58058;

    /// <inheritdoc />
    public virtual string GenusName => "Aproteles";

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
