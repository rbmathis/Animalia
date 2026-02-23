using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhylidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhylidae_incertae_sedis.Synapturanus;

/// <summary>
/// Abstract class for Synapturanus (genus).
/// NCBI TaxId: 356333
/// </summary>
public abstract class Synapturanus : Microhylidae_incertae_sedis, ISynapturanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Synapturanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356333;

    /// <inheritdoc />
    public virtual string GenusName => "Synapturanus";

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
