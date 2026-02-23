using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Trachydactylus;

/// <summary>
/// Abstract class for Trachydactylus (genus).
/// NCBI TaxId: 2025558
/// </summary>
public abstract class Trachydactylus : Gekkonidae, ITrachydactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachydactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2025558;

    /// <inheritdoc />
    public virtual string GenusName => "Trachydactylus";

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
