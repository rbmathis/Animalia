using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Megadermatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Megadermatidae.Macroderma;

/// <summary>
/// Abstract class for Macroderma (genus).
/// NCBI TaxId: 9410
/// </summary>
public abstract class Macroderma : Megadermatidae, IMacroderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macroderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9410;

    /// <inheritdoc />
    public virtual string GenusName => "Macroderma";

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
