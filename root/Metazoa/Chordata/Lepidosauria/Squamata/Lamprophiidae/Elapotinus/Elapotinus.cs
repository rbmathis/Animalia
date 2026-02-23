using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Elapotinus;

/// <summary>
/// Abstract class for Elapotinus (genus).
/// NCBI TaxId: 1544577
/// </summary>
public abstract class Elapotinus : Lamprophiidae, IElapotinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elapotinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544577;

    /// <inheritdoc />
    public virtual string GenusName => "Elapotinus";

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
