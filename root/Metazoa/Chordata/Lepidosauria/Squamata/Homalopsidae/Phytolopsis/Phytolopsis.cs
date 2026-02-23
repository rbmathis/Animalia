using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Phytolopsis;

/// <summary>
/// Abstract class for Phytolopsis (genus).
/// NCBI TaxId: 2230920
/// </summary>
public abstract class Phytolopsis : Homalopsidae, IPhytolopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phytolopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2230920;

    /// <inheritdoc />
    public virtual string GenusName => "Phytolopsis";

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
