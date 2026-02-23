using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Macrourus;

/// <summary>
/// Abstract class for Macrourus (genus).
/// NCBI TaxId: 68520
/// </summary>
public abstract class Macrourus : Macrouridae, IMacrourus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrourus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68520;

    /// <inheritdoc />
    public virtual string GenusName => "Macrourus";

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
