using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.Dysomma;

/// <summary>
/// Abstract class for Dysomma (genus).
/// NCBI TaxId: 189483
/// </summary>
public abstract class Dysomma : Synaphobranchidae, IDysomma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dysomma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 189483;

    /// <inheritdoc />
    public virtual string GenusName => "Dysomma";

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
