using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Gymnocaesio;

/// <summary>
/// Abstract class for Gymnocaesio (genus).
/// NCBI TaxId: 490327
/// </summary>
public abstract class Gymnocaesio : Lutjanidae, IGymnocaesio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnocaesio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 490327;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnocaesio";

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
