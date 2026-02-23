using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Blaesodactylus;

/// <summary>
/// Abstract class for Blaesodactylus (genus).
/// NCBI TaxId: 290509
/// </summary>
public abstract class Blaesodactylus : Gekkonidae, IBlaesodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Blaesodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 290509;

    /// <inheritdoc />
    public virtual string GenusName => "Blaesodactylus";

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
