using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Mintonophis;

/// <summary>
/// Abstract class for Mintonophis (genus).
/// NCBI TaxId: 2911142
/// </summary>
public abstract class Mintonophis : Homalopsidae, IMintonophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mintonophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2911142;

    /// <inheritdoc />
    public virtual string GenusName => "Mintonophis";

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
