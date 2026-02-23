using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Synapturichthys;

/// <summary>
/// Abstract class for Synapturichthys (genus).
/// NCBI TaxId: 425390
/// </summary>
public abstract class Synapturichthys : Soleidae, ISynapturichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Synapturichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 425390;

    /// <inheritdoc />
    public virtual string GenusName => "Synapturichthys";

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
