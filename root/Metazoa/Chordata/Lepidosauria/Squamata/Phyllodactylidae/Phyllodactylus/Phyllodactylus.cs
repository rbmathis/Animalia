using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Phyllodactylus;

/// <summary>
/// Abstract class for Phyllodactylus (genus).
/// NCBI TaxId: 71028
/// </summary>
public abstract class Phyllodactylus : Phyllodactylidae, IPhyllodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyllodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71028;

    /// <inheritdoc />
    public virtual string GenusName => "Phyllodactylus";

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
