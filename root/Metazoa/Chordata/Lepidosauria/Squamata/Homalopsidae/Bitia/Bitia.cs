using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Bitia;

/// <summary>
/// Abstract class for Bitia (genus).
/// NCBI TaxId: 445404
/// </summary>
public abstract class Bitia : Homalopsidae, IBitia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bitia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 445404;

    /// <inheritdoc />
    public virtual string GenusName => "Bitia";

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
