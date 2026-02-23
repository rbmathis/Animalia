using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenodermatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenodermatidae.Xylophis;

/// <summary>
/// Abstract class for Xylophis (genus).
/// NCBI TaxId: 1546061
/// </summary>
public abstract class Xylophis : Xenodermatidae, IXylophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xylophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1546061;

    /// <inheritdoc />
    public virtual string GenusName => "Xylophis";

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
