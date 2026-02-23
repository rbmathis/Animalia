using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Lutjanus;

/// <summary>
/// Abstract class for Lutjanus (genus).
/// NCBI TaxId: 40493
/// </summary>
public abstract class Lutjanus : Lutjanidae, ILutjanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lutjanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 40493;

    /// <inheritdoc />
    public virtual string GenusName => "Lutjanus";

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
