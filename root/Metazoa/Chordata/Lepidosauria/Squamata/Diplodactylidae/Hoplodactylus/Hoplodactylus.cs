using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Hoplodactylus;

/// <summary>
/// Abstract class for Hoplodactylus (genus).
/// NCBI TaxId: 150460
/// </summary>
public abstract class Hoplodactylus : Diplodactylidae, IHoplodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoplodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150460;

    /// <inheritdoc />
    public virtual string GenusName => "Hoplodactylus";

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
