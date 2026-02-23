using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Parophrys;

/// <summary>
/// Abstract class for Parophrys (genus).
/// NCBI TaxId: 172658
/// </summary>
public abstract class Parophrys : Pleuronectidae, IParophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172658;

    /// <inheritdoc />
    public virtual string GenusName => "Parophrys";

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
