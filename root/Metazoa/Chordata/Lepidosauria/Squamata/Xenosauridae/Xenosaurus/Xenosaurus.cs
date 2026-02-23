using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenosauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenosauridae.Xenosaurus;

/// <summary>
/// Abstract class for Xenosaurus (genus).
/// NCBI TaxId: 52182
/// </summary>
public abstract class Xenosaurus : Xenosauridae, IXenosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52182;

    /// <inheritdoc />
    public virtual string GenusName => "Xenosaurus";

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
