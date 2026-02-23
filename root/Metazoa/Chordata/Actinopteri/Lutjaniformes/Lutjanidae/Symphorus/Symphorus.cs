using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Symphorus;

/// <summary>
/// Abstract class for Symphorus (genus).
/// NCBI TaxId: 396797
/// </summary>
public abstract class Symphorus : Lutjanidae, ISymphorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Symphorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 396797;

    /// <inheritdoc />
    public virtual string GenusName => "Symphorus";

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
