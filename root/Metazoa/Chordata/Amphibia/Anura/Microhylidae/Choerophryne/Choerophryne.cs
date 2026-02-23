using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Choerophryne;

/// <summary>
/// Abstract class for Choerophryne (genus).
/// NCBI TaxId: 356289
/// </summary>
public abstract class Choerophryne : Microhylidae, IChoerophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Choerophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356289;

    /// <inheritdoc />
    public virtual string GenusName => "Choerophryne";

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
