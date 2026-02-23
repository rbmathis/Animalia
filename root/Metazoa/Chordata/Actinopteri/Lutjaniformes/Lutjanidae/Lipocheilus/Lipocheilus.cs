using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Lipocheilus;

/// <summary>
/// Abstract class for Lipocheilus (genus).
/// NCBI TaxId: 1828470
/// </summary>
public abstract class Lipocheilus : Lutjanidae, ILipocheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lipocheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1828470;

    /// <inheritdoc />
    public virtual string GenusName => "Lipocheilus";

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
