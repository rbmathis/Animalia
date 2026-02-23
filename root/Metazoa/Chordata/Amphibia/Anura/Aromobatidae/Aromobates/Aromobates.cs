using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.Aromobates;

/// <summary>
/// Abstract class for Aromobates (genus).
/// NCBI TaxId: 384923
/// </summary>
public abstract class Aromobates : Aromobatidae, IAromobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aromobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 384923;

    /// <inheritdoc />
    public virtual string GenusName => "Aromobates";

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
