using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Nectophryne;

/// <summary>
/// Abstract class for Nectophryne (genus).
/// NCBI TaxId: 164284
/// </summary>
public abstract class Nectophryne : Bufonidae, INectophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nectophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 164284;

    /// <inheritdoc />
    public virtual string GenusName => "Nectophryne";

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
