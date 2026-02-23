using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Myanophis;

/// <summary>
/// Abstract class for Myanophis (genus).
/// NCBI TaxId: 2822136
/// </summary>
public abstract class Myanophis : Homalopsidae, IMyanophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myanophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2822136;

    /// <inheritdoc />
    public virtual string GenusName => "Myanophis";

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
