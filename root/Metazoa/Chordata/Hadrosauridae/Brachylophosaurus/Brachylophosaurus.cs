using AnimalKingdom.root.Metazoa.Chordata.Hadrosauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Hadrosauridae.Brachylophosaurus;

/// <summary>
/// Abstract class for Brachylophosaurus (genus).
/// NCBI TaxId: 643744
/// </summary>
public abstract class Brachylophosaurus : Hadrosauridae, IBrachylophosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachylophosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 643744;

    /// <inheritdoc />
    public virtual string GenusName => "Brachylophosaurus";

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
