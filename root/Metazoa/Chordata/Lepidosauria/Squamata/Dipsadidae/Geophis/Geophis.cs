using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Geophis;

/// <summary>
/// Abstract class for Geophis (genus).
/// NCBI TaxId: 699580
/// </summary>
public abstract class Geophis : Dipsadidae, IGeophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 699580;

    /// <inheritdoc />
    public virtual string GenusName => "Geophis";

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
