using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Mediodactylus;

/// <summary>
/// Abstract class for Mediodactylus (genus).
/// NCBI TaxId: 1133301
/// </summary>
public abstract class Mediodactylus : Gekkonidae, IMediodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mediodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1133301;

    /// <inheritdoc />
    public virtual string GenusName => "Mediodactylus";

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
