using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Cacophis;

/// <summary>
/// Abstract class for Cacophis (genus).
/// NCBI TaxId: 505433
/// </summary>
public abstract class Cacophis : Elapidae, ICacophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cacophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 505433;

    /// <inheritdoc />
    public virtual string GenusName => "Cacophis";

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
