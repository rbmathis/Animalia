using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Miralia;

/// <summary>
/// Abstract class for Miralia (genus).
/// NCBI TaxId: 2906470
/// </summary>
public abstract class Miralia : Homalopsidae, IMiralia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Miralia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2906470;

    /// <inheritdoc />
    public virtual string GenusName => "Miralia";

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
