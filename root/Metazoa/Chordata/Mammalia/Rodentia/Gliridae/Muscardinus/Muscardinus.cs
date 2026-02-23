using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae.Muscardinus;

/// <summary>
/// Abstract class for Muscardinus (genus).
/// NCBI TaxId: 39081
/// </summary>
public abstract class Muscardinus : Gliridae, IMuscardinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Muscardinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39081;

    /// <inheritdoc />
    public virtual string GenusName => "Muscardinus";

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
