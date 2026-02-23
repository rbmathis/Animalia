using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Chlopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Chlopsidae.Xenoconger;

/// <summary>
/// Abstract class for Xenoconger (genus).
/// NCBI TaxId: 1604596
/// </summary>
public abstract class Xenoconger : Chlopsidae, IXenoconger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenoconger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1604596;

    /// <inheritdoc />
    public virtual string GenusName => "Xenoconger";

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
