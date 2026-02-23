using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae.Hyperoodon;

/// <summary>
/// Abstract class for Hyperoodon (genus).
/// NCBI TaxId: 48743
/// </summary>
public abstract class Hyperoodon : Ziphiidae, IHyperoodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyperoodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48743;

    /// <inheritdoc />
    public virtual string GenusName => "Hyperoodon";

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
