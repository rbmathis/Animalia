using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Dieurostus;

/// <summary>
/// Abstract class for Dieurostus (genus).
/// NCBI TaxId: 1401515
/// </summary>
public abstract class Dieurostus : Homalopsidae, IDieurostus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dieurostus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1401515;

    /// <inheritdoc />
    public virtual string GenusName => "Dieurostus";

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
