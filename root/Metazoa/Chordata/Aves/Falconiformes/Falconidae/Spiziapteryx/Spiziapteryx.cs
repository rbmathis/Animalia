using AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Spiziapteryx;

/// <summary>
/// Abstract class for Spiziapteryx (genus).
/// NCBI TaxId: 56331
/// </summary>
public abstract class Spiziapteryx : Falconidae, ISpiziapteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spiziapteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56331;

    /// <inheritdoc />
    public virtual string GenusName => "Spiziapteryx";

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
