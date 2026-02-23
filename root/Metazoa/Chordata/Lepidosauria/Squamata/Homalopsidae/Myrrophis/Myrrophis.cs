using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Myrrophis;

/// <summary>
/// Abstract class for Myrrophis (genus).
/// NCBI TaxId: 1401514
/// </summary>
public abstract class Myrrophis : Homalopsidae, IMyrrophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myrrophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1401514;

    /// <inheritdoc />
    public virtual string GenusName => "Myrrophis";

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
