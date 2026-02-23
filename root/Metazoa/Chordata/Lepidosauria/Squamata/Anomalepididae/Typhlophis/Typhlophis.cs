using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anomalepididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anomalepididae.Typhlophis;

/// <summary>
/// Abstract class for Typhlophis (genus).
/// NCBI TaxId: 759942
/// </summary>
public abstract class Typhlophis : Anomalepididae, ITyphlophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Typhlophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 759942;

    /// <inheritdoc />
    public virtual string GenusName => "Typhlophis";

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
