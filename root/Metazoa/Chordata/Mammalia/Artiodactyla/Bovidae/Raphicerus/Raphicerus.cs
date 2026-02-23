using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Raphicerus;

/// <summary>
/// Abstract class for Raphicerus (genus).
/// NCBI TaxId: 59543
/// </summary>
public abstract class Raphicerus : Bovidae, IRaphicerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Raphicerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59543;

    /// <inheritdoc />
    public virtual string GenusName => "Raphicerus";

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
