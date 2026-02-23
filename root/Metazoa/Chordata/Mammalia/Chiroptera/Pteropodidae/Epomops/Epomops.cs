using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Epomops;

/// <summary>
/// Abstract class for Epomops (genus).
/// NCBI TaxId: 77230
/// </summary>
public abstract class Epomops : Pteropodidae, IEpomops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Epomops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 77230;

    /// <inheritdoc />
    public virtual string GenusName => "Epomops";

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
