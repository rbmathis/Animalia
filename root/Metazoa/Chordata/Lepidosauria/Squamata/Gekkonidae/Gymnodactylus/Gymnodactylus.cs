using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gymnodactylus;

/// <summary>
/// Abstract class for Gymnodactylus (genus).
/// NCBI TaxId: 298112
/// </summary>
public abstract class Gymnodactylus : Gekkonidae, IGymnodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 298112;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnodactylus";

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
