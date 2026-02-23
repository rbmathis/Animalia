using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Mirimiri;

/// <summary>
/// Abstract class for Mirimiri (genus).
/// NCBI TaxId: 1496136
/// </summary>
public abstract class Mirimiri : Pteropodidae, IMirimiri
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mirimiri";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1496136;

    /// <inheritdoc />
    public virtual string GenusName => "Mirimiri";

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
