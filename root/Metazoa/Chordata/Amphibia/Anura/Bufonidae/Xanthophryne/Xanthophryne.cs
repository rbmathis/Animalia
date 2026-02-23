using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Xanthophryne;

/// <summary>
/// Abstract class for Xanthophryne (genus).
/// NCBI TaxId: 1210401
/// </summary>
public abstract class Xanthophryne : Bufonidae, IXanthophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xanthophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1210401;

    /// <inheritdoc />
    public virtual string GenusName => "Xanthophryne";

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
