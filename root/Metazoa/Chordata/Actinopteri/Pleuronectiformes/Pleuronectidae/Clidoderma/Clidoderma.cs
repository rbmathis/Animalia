using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Clidoderma;

/// <summary>
/// Abstract class for Clidoderma (genus).
/// NCBI TaxId: 255559
/// </summary>
public abstract class Clidoderma : Pleuronectidae, IClidoderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clidoderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 255559;

    /// <inheritdoc />
    public virtual string GenusName => "Clidoderma";

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
