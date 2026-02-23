using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Lyciasalamandra;

/// <summary>
/// Abstract class for Lyciasalamandra (genus).
/// NCBI TaxId: 297009
/// </summary>
public abstract class Lyciasalamandra : Salamandridae, ILyciasalamandra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lyciasalamandra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 297009;

    /// <inheritdoc />
    public virtual string GenusName => "Lyciasalamandra";

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
