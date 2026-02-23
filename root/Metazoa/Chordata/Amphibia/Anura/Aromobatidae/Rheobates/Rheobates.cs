using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.Rheobates;

/// <summary>
/// Abstract class for Rheobates (genus).
/// NCBI TaxId: 479887
/// </summary>
public abstract class Rheobates : Aromobatidae, IRheobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rheobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 479887;

    /// <inheritdoc />
    public virtual string GenusName => "Rheobates";

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
