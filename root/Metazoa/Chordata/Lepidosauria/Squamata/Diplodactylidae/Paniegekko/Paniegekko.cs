using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Paniegekko;

/// <summary>
/// Abstract class for Paniegekko (genus).
/// NCBI TaxId: 1385381
/// </summary>
public abstract class Paniegekko : Diplodactylidae, IPaniegekko
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paniegekko";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1385381;

    /// <inheritdoc />
    public virtual string GenusName => "Paniegekko";

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
