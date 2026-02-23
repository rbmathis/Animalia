using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Elasmodactylus;

/// <summary>
/// Abstract class for Elasmodactylus (genus).
/// NCBI TaxId: 460632
/// </summary>
public abstract class Elasmodactylus : Gekkonidae, IElasmodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elasmodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 460632;

    /// <inheritdoc />
    public virtual string GenusName => "Elasmodactylus";

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
