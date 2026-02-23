using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Micromacronus;

/// <summary>
/// Abstract class for Micromacronus (genus).
/// NCBI TaxId: 1149647
/// </summary>
public abstract class Micromacronus : Timaliidae, IMicromacronus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micromacronus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1149647;

    /// <inheritdoc />
    public virtual string GenusName => "Micromacronus";

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
