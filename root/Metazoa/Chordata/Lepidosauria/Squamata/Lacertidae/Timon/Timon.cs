using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Timon;

/// <summary>
/// Abstract class for Timon (genus).
/// NCBI TaxId: 399534
/// </summary>
public abstract class Timon : Lacertidae, ITimon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Timon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 399534;

    /// <inheritdoc />
    public virtual string GenusName => "Timon";

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
