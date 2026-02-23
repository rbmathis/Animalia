using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Xenodon;

/// <summary>
/// Abstract class for Xenodon (genus).
/// NCBI TaxId: 39151
/// </summary>
public abstract class Xenodon : Dipsadidae, IXenodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39151;

    /// <inheritdoc />
    public virtual string GenusName => "Xenodon";

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
