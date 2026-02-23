using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Reinhardtius;

/// <summary>
/// Abstract class for Reinhardtius (genus).
/// NCBI TaxId: 111783
/// </summary>
public abstract class Reinhardtius : Pleuronectidae, IReinhardtius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Reinhardtius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111783;

    /// <inheritdoc />
    public virtual string GenusName => "Reinhardtius";

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
