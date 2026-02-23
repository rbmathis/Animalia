using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Ichthyophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Ichthyophiidae.Ichthyophis;

/// <summary>
/// Abstract class for Ichthyophis (genus).
/// NCBI TaxId: 8452
/// </summary>
public abstract class Ichthyophis : Ichthyophiidae, IIchthyophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ichthyophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8452;

    /// <inheritdoc />
    public virtual string GenusName => "Ichthyophis";

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
