using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Eurydactylodes;

/// <summary>
/// Abstract class for Eurydactylodes (genus).
/// NCBI TaxId: 385261
/// </summary>
public abstract class Eurydactylodes : Diplodactylidae, IEurydactylodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eurydactylodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 385261;

    /// <inheritdoc />
    public virtual string GenusName => "Eurydactylodes";

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
