using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Lepidodactylus;

/// <summary>
/// Abstract class for Lepidodactylus (genus).
/// NCBI TaxId: 47722
/// </summary>
public abstract class Lepidodactylus : Gekkonidae, ILepidodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 47722;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidodactylus";

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
