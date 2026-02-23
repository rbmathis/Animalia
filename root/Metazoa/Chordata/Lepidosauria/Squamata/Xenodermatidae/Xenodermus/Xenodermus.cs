using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenodermatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenodermatidae.Xenodermus;

/// <summary>
/// Abstract class for Xenodermus (genus).
/// NCBI TaxId: 46277
/// </summary>
public abstract class Xenodermus : Xenodermatidae, IXenodermus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenodermus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46277;

    /// <inheritdoc />
    public virtual string GenusName => "Xenodermus";

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
