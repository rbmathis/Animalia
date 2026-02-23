using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Cleisthenes;

/// <summary>
/// Abstract class for Cleisthenes (genus).
/// NCBI TaxId: 244448
/// </summary>
public abstract class Cleisthenes : Pleuronectidae, ICleisthenes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cleisthenes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 244448;

    /// <inheritdoc />
    public virtual string GenusName => "Cleisthenes";

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
