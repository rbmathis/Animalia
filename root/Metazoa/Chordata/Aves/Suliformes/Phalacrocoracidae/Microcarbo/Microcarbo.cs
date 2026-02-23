using AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Phalacrocoracidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Phalacrocoracidae.Microcarbo;

/// <summary>
/// Abstract class for Microcarbo (genus).
/// NCBI TaxId: 1517964
/// </summary>
public abstract class Microcarbo : Phalacrocoracidae, IMicrocarbo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microcarbo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1517964;

    /// <inheritdoc />
    public virtual string GenusName => "Microcarbo";

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
