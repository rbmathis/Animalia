using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Haringtonhippus;

/// <summary>
/// Abstract class for Haringtonhippus (genus).
/// NCBI TaxId: 2055936
/// </summary>
public abstract class Haringtonhippus : Equidae, IHaringtonhippus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haringtonhippus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2055936;

    /// <inheritdoc />
    public virtual string GenusName => "Haringtonhippus";

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
