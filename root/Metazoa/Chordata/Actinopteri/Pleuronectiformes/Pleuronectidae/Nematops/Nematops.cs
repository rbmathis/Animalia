using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Nematops;

/// <summary>
/// Abstract class for Nematops (genus).
/// NCBI TaxId: 2665444
/// </summary>
public abstract class Nematops : Pleuronectidae, INematops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nematops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2665444;

    /// <inheritdoc />
    public virtual string GenusName => "Nematops";

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
