using AnimalKingdom.root.Metazoa.Chordata.Aves.Dinornithiformes.Emeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Dinornithiformes.Emeidae.Megalapteryx;

/// <summary>
/// Abstract class for Megalapteryx (genus).
/// NCBI TaxId: 8812
/// </summary>
public abstract class Megalapteryx : Emeidae, IMegalapteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megalapteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8812;

    /// <inheritdoc />
    public virtual string GenusName => "Megalapteryx";

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
