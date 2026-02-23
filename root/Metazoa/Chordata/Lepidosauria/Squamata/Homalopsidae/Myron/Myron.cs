using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Myron;

/// <summary>
/// Abstract class for Myron (genus).
/// NCBI TaxId: 192600
/// </summary>
public abstract class Myron : Homalopsidae, IMyron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 192600;

    /// <inheritdoc />
    public virtual string GenusName => "Myron";

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
