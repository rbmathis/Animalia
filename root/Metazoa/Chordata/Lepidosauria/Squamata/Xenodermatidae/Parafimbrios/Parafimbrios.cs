using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenodermatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenodermatidae.Parafimbrios;

/// <summary>
/// Abstract class for Parafimbrios (genus).
/// NCBI TaxId: 1634187
/// </summary>
public abstract class Parafimbrios : Xenodermatidae, IParafimbrios
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parafimbrios";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1634187;

    /// <inheritdoc />
    public virtual string GenusName => "Parafimbrios";

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
