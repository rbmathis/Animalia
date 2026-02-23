using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Cyrtodactylus;

/// <summary>
/// Abstract class for Cyrtodactylus (genus).
/// NCBI TaxId: 96732
/// </summary>
public abstract class Cyrtodactylus : Gekkonidae, ICyrtodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyrtodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 96732;

    /// <inheritdoc />
    public virtual string GenusName => "Cyrtodactylus";

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
