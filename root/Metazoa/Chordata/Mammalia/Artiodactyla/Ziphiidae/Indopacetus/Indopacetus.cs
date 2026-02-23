using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae.Indopacetus;

/// <summary>
/// Abstract class for Indopacetus (genus).
/// NCBI TaxId: 221923
/// </summary>
public abstract class Indopacetus : Ziphiidae, IIndopacetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Indopacetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 221923;

    /// <inheritdoc />
    public virtual string GenusName => "Indopacetus";

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
