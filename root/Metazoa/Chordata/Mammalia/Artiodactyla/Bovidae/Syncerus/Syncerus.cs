using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Syncerus;

/// <summary>
/// Abstract class for Syncerus (genus).
/// NCBI TaxId: 9969
/// </summary>
public abstract class Syncerus : Bovidae, ISyncerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Syncerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9969;

    /// <inheritdoc />
    public virtual string GenusName => "Syncerus";

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
