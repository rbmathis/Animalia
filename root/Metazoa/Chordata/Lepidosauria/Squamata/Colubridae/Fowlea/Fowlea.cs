using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Fowlea;

/// <summary>
/// Abstract class for Fowlea (genus).
/// NCBI TaxId: 2743193
/// </summary>
public abstract class Fowlea : Colubridae, IFowlea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fowlea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2743193;

    /// <inheritdoc />
    public virtual string GenusName => "Fowlea";

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
