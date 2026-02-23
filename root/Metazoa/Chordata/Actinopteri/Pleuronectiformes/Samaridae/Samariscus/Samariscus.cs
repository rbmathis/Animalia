using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Samaridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Samaridae.Samariscus;

/// <summary>
/// Abstract class for Samariscus (genus).
/// NCBI TaxId: 195646
/// </summary>
public abstract class Samariscus : Samaridae, ISamariscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Samariscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195646;

    /// <inheritdoc />
    public virtual string GenusName => "Samariscus";

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
