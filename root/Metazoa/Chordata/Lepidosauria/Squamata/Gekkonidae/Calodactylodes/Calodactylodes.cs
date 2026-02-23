using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Calodactylodes;

/// <summary>
/// Abstract class for Calodactylodes (genus).
/// NCBI TaxId: 221553
/// </summary>
public abstract class Calodactylodes : Gekkonidae, ICalodactylodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calodactylodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 221553;

    /// <inheritdoc />
    public virtual string GenusName => "Calodactylodes";

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
