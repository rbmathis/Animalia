using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Holodactylus;

/// <summary>
/// Abstract class for Holodactylus (genus).
/// NCBI TaxId: 96742
/// </summary>
public abstract class Holodactylus : Diplodactylidae, IHolodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Holodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 96742;

    /// <inheritdoc />
    public virtual string GenusName => "Holodactylus";

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
