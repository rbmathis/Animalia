using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhylidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhylidae_incertae_sedis.Melanophryne;

/// <summary>
/// Abstract class for Melanophryne (genus).
/// NCBI TaxId: 1217965
/// </summary>
public abstract class Melanophryne : Microhylidae_incertae_sedis, IMelanophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1217965;

    /// <inheritdoc />
    public virtual string GenusName => "Melanophryne";

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
