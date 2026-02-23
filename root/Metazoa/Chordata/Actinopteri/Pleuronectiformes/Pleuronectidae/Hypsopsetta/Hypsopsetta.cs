using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Hypsopsetta;

/// <summary>
/// Abstract class for Hypsopsetta (genus).
/// NCBI TaxId: 320377
/// </summary>
public abstract class Hypsopsetta : Pleuronectidae, IHypsopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypsopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320377;

    /// <inheritdoc />
    public virtual string GenusName => "Hypsopsetta";

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
