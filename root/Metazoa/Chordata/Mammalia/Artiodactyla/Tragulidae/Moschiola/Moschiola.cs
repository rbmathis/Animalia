using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tragulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tragulidae.Moschiola;

/// <summary>
/// Abstract class for Moschiola (genus).
/// NCBI TaxId: 439460
/// </summary>
public abstract class Moschiola : Tragulidae, IMoschiola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Moschiola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 439460;

    /// <inheritdoc />
    public virtual string GenusName => "Moschiola";

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
