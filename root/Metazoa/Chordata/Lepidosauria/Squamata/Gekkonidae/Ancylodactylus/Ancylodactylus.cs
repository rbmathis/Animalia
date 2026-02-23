using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Ancylodactylus;

/// <summary>
/// Abstract class for Ancylodactylus (genus).
/// NCBI TaxId: 3144863
/// </summary>
public abstract class Ancylodactylus : Gekkonidae, IAncylodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ancylodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3144863;

    /// <inheritdoc />
    public virtual string GenusName => "Ancylodactylus";

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
