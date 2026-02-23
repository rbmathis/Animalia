using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Ptyodactylus;

/// <summary>
/// Abstract class for Ptyodactylus (genus).
/// NCBI TaxId: 502502
/// </summary>
public abstract class Ptyodactylus : Phyllodactylidae, IPtyodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptyodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 502502;

    /// <inheritdoc />
    public virtual string GenusName => "Ptyodactylus";

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
