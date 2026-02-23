using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Nectophrynoides;

/// <summary>
/// Abstract class for Nectophrynoides (genus).
/// NCBI TaxId: 164286
/// </summary>
public abstract class Nectophrynoides : Bufonidae, INectophrynoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nectophrynoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 164286;

    /// <inheritdoc />
    public virtual string GenusName => "Nectophrynoides";

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
