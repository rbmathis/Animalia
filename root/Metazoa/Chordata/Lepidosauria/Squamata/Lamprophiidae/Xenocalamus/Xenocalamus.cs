using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Xenocalamus;

/// <summary>
/// Abstract class for Xenocalamus (genus).
/// NCBI TaxId: 292855
/// </summary>
public abstract class Xenocalamus : Lamprophiidae, IXenocalamus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenocalamus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 292855;

    /// <inheritdoc />
    public virtual string GenusName => "Xenocalamus";

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
