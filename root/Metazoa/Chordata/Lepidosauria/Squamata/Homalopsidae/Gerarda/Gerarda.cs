using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Gerarda;

/// <summary>
/// Abstract class for Gerarda (genus).
/// NCBI TaxId: 192596
/// </summary>
public abstract class Gerarda : Homalopsidae, IGerarda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gerarda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 192596;

    /// <inheritdoc />
    public virtual string GenusName => "Gerarda";

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
