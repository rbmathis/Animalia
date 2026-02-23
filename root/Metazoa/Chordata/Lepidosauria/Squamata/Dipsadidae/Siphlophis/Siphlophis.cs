using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Siphlophis;

/// <summary>
/// Abstract class for Siphlophis (genus).
/// NCBI TaxId: 121365
/// </summary>
public abstract class Siphlophis : Dipsadidae, ISiphlophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Siphlophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121365;

    /// <inheritdoc />
    public virtual string GenusName => "Siphlophis";

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
