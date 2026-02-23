using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Hemiphyllodactylus;

/// <summary>
/// Abstract class for Hemiphyllodactylus (genus).
/// NCBI TaxId: 221561
/// </summary>
public abstract class Hemiphyllodactylus : Gekkonidae, IHemiphyllodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemiphyllodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 221561;

    /// <inheritdoc />
    public virtual string GenusName => "Hemiphyllodactylus";

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
