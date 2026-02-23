using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Samaridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Samaridae.Samaris;

/// <summary>
/// Abstract class for Samaris (genus).
/// NCBI TaxId: 366933
/// </summary>
public abstract class Samaris : Samaridae, ISamaris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Samaris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 366933;

    /// <inheritdoc />
    public virtual string GenusName => "Samaris";

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
