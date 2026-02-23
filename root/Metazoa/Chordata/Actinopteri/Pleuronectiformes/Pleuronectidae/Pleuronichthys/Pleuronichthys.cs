using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Pleuronichthys;

/// <summary>
/// Abstract class for Pleuronichthys (genus).
/// NCBI TaxId: 195633
/// </summary>
public abstract class Pleuronichthys : Pleuronectidae, IPleuronichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pleuronichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195633;

    /// <inheritdoc />
    public virtual string GenusName => "Pleuronichthys";

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
