using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Ctenophryne;

/// <summary>
/// Abstract class for Ctenophryne (genus).
/// NCBI TaxId: 356294
/// </summary>
public abstract class Ctenophryne : Microhylidae, ICtenophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ctenophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356294;

    /// <inheritdoc />
    public virtual string GenusName => "Ctenophryne";

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
