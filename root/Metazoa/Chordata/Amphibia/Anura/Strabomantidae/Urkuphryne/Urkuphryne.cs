using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Urkuphryne;

/// <summary>
/// Abstract class for Urkuphryne (genus).
/// NCBI TaxId: 3405133
/// </summary>
public abstract class Urkuphryne : Strabomantidae, IUrkuphryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urkuphryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3405133;

    /// <inheritdoc />
    public virtual string GenusName => "Urkuphryne";

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
