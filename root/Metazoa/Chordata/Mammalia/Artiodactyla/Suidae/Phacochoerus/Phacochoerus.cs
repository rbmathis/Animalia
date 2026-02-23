using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Phacochoerus;

/// <summary>
/// Abstract class for Phacochoerus (genus).
/// NCBI TaxId: 41425
/// </summary>
public abstract class Phacochoerus : Suidae, IPhacochoerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phacochoerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 41425;

    /// <inheritdoc />
    public virtual string GenusName => "Phacochoerus";

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
