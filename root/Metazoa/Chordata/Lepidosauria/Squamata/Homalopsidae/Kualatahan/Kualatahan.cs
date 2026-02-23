using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Kualatahan;

/// <summary>
/// Abstract class for Kualatahan (genus).
/// NCBI TaxId: 2911146
/// </summary>
public abstract class Kualatahan : Homalopsidae, IKualatahan
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kualatahan";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2911146;

    /// <inheritdoc />
    public virtual string GenusName => "Kualatahan";

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
