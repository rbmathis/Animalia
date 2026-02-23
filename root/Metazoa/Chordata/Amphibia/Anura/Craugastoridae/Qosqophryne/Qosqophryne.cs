using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Qosqophryne;

/// <summary>
/// Abstract class for Qosqophryne (genus).
/// NCBI TaxId: 2853287
/// </summary>
public abstract class Qosqophryne : Craugastoridae, IQosqophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Qosqophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2853287;

    /// <inheritdoc />
    public virtual string GenusName => "Qosqophryne";

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
