using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae.Tasmacetus;

/// <summary>
/// Abstract class for Tasmacetus (genus).
/// NCBI TaxId: 52115
/// </summary>
public abstract class Tasmacetus : Ziphiidae, ITasmacetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tasmacetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52115;

    /// <inheritdoc />
    public virtual string GenusName => "Tasmacetus";

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
