using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenodermatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenodermatidae.Fimbrios;

/// <summary>
/// Abstract class for Fimbrios (genus).
/// NCBI TaxId: 1544589
/// </summary>
public abstract class Fimbrios : Xenodermatidae, IFimbrios
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fimbrios";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544589;

    /// <inheritdoc />
    public virtual string GenusName => "Fimbrios";

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
