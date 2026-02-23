using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Rangifer;

/// <summary>
/// Abstract class for Rangifer (genus).
/// NCBI TaxId: 9869
/// </summary>
public abstract class Rangifer : Cervidae, IRangifer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rangifer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9869;

    /// <inheritdoc />
    public virtual string GenusName => "Rangifer";

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
