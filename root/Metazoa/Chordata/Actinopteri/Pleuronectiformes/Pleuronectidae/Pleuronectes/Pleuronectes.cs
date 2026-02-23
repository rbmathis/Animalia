using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Pleuronectes;

/// <summary>
/// Abstract class for Pleuronectes (genus).
/// NCBI TaxId: 8261
/// </summary>
public abstract class Pleuronectes : Pleuronectidae, IPleuronectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pleuronectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8261;

    /// <inheritdoc />
    public virtual string GenusName => "Pleuronectes";

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
