using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Aphareus;

/// <summary>
/// Abstract class for Aphareus (genus).
/// NCBI TaxId: 396778
/// </summary>
public abstract class Aphareus : Lutjanidae, IAphareus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphareus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 396778;

    /// <inheritdoc />
    public virtual string GenusName => "Aphareus";

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
