using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Stenodactylus;

/// <summary>
/// Abstract class for Stenodactylus (genus).
/// NCBI TaxId: 94422
/// </summary>
public abstract class Stenodactylus : Gekkonidae, IStenodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stenodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94422;

    /// <inheritdoc />
    public virtual string GenusName => "Stenodactylus";

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
