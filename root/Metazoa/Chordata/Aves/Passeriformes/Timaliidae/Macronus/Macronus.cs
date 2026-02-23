using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Macronus;

/// <summary>
/// Abstract class for Macronus (genus).
/// NCBI TaxId: 2478781
/// </summary>
public abstract class Macronus : Timaliidae, IMacronus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macronus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2478781;

    /// <inheritdoc />
    public virtual string GenusName => "Macronus";

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
