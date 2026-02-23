using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neomicroxus;

/// <summary>
/// Abstract class for Neomicroxus (genus).
/// NCBI TaxId: 2833617
/// </summary>
public abstract class Neomicroxus : Cricetidae, INeomicroxus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neomicroxus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2833617;

    /// <inheritdoc />
    public virtual string GenusName => "Neomicroxus";

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
