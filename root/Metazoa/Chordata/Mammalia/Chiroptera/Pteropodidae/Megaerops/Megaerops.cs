using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Megaerops;

/// <summary>
/// Abstract class for Megaerops (genus).
/// NCBI TaxId: 77232
/// </summary>
public abstract class Megaerops : Pteropodidae, IMegaerops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megaerops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 77232;

    /// <inheritdoc />
    public virtual string GenusName => "Megaerops";

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
