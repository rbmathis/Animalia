using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Azygopus;

/// <summary>
/// Abstract class for Azygopus (genus).
/// NCBI TaxId: 2696647
/// </summary>
public abstract class Azygopus : Pleuronectidae, IAzygopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Azygopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696647;

    /// <inheritdoc />
    public virtual string GenusName => "Azygopus";

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
