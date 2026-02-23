using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Madoqua;

/// <summary>
/// Abstract class for Madoqua (genus).
/// NCBI TaxId: 9950
/// </summary>
public abstract class Madoqua : Bovidae, IMadoqua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Madoqua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9950;

    /// <inheritdoc />
    public virtual string GenusName => "Madoqua";

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
