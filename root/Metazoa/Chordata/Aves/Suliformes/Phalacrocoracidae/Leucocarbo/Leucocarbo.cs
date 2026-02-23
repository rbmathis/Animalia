using AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Phalacrocoracidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Phalacrocoracidae.Leucocarbo;

/// <summary>
/// Abstract class for Leucocarbo (genus).
/// NCBI TaxId: 1523025
/// </summary>
public abstract class Leucocarbo : Phalacrocoracidae, ILeucocarbo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leucocarbo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1523025;

    /// <inheritdoc />
    public virtual string GenusName => "Leucocarbo";

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
