using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Macrotrema;

/// <summary>
/// Abstract class for Macrotrema (genus).
/// NCBI TaxId: 3070629
/// </summary>
public abstract class Macrotrema : Synbranchidae, IMacrotrema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrotrema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3070629;

    /// <inheritdoc />
    public virtual string GenusName => "Macrotrema";

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
