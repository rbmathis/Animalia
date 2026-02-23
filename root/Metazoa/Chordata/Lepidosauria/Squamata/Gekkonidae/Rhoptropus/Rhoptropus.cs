using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Rhoptropus;

/// <summary>
/// Abstract class for Rhoptropus (genus).
/// NCBI TaxId: 152584
/// </summary>
public abstract class Rhoptropus : Gekkonidae, IRhoptropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhoptropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 152584;

    /// <inheritdoc />
    public virtual string GenusName => "Rhoptropus";

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
