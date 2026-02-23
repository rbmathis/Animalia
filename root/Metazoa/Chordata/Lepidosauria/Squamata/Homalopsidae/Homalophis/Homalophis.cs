using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Homalophis;

/// <summary>
/// Abstract class for Homalophis (genus).
/// NCBI TaxId: 2911139
/// </summary>
public abstract class Homalophis : Homalopsidae, IHomalophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Homalophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2911139;

    /// <inheritdoc />
    public virtual string GenusName => "Homalophis";

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
