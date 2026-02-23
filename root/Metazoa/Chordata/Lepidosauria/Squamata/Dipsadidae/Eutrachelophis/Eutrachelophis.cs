using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Eutrachelophis;

/// <summary>
/// Abstract class for Eutrachelophis (genus).
/// NCBI TaxId: 1544585
/// </summary>
public abstract class Eutrachelophis : Dipsadidae, IEutrachelophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eutrachelophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544585;

    /// <inheritdoc />
    public virtual string GenusName => "Eutrachelophis";

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
