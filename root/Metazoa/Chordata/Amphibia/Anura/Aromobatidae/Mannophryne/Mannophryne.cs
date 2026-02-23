using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Aromobatidae.Mannophryne;

/// <summary>
/// Abstract class for Mannophryne (genus).
/// NCBI TaxId: 187288
/// </summary>
public abstract class Mannophryne : Aromobatidae, IMannophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mannophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187288;

    /// <inheritdoc />
    public virtual string GenusName => "Mannophryne";

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
