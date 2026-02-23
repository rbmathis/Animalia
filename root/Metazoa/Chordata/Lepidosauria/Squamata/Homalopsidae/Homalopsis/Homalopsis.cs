using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Homalopsis;

/// <summary>
/// Abstract class for Homalopsis (genus).
/// NCBI TaxId: 192598
/// </summary>
public abstract class Homalopsis : Homalopsidae, IHomalopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Homalopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 192598;

    /// <inheritdoc />
    public virtual string GenusName => "Homalopsis";

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
