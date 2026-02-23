using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anomochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anomochilidae.Anomochilus;

/// <summary>
/// Abstract class for Anomochilus (genus).
/// NCBI TaxId: 327153
/// </summary>
public abstract class Anomochilus : Anomochilidae, IAnomochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anomochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 327153;

    /// <inheritdoc />
    public virtual string GenusName => "Anomochilus";

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
