using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Verasper;

/// <summary>
/// Abstract class for Verasper (genus).
/// NCBI TaxId: 82365
/// </summary>
public abstract class Verasper : Pleuronectidae, IVerasper
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Verasper";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 82365;

    /// <inheritdoc />
    public virtual string GenusName => "Verasper";

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
