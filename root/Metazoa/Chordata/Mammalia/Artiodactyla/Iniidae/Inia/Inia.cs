using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Iniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Iniidae.Inia;

/// <summary>
/// Abstract class for Inia (genus).
/// NCBI TaxId: 9724
/// </summary>
public abstract class Inia : Iniidae, IInia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Inia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9724;

    /// <inheritdoc />
    public virtual string GenusName => "Inia";

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
