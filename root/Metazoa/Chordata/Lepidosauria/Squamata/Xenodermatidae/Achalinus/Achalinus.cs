using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenodermatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenodermatidae.Achalinus;

/// <summary>
/// Abstract class for Achalinus (genus).
/// NCBI TaxId: 46275
/// </summary>
public abstract class Achalinus : Xenodermatidae, IAchalinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Achalinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46275;

    /// <inheritdoc />
    public virtual string GenusName => "Achalinus";

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
