using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Macrosmia;

/// <summary>
/// Abstract class for Macrosmia (genus).
/// NCBI TaxId: 1916799
/// </summary>
public abstract class Macrosmia : Macrouridae, IMacrosmia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrosmia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1916799;

    /// <inheritdoc />
    public virtual string GenusName => "Macrosmia";

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
