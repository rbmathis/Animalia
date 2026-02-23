using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Isopsetta;

/// <summary>
/// Abstract class for Isopsetta (genus).
/// NCBI TaxId: 195616
/// </summary>
public abstract class Isopsetta : Pleuronectidae, IIsopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Isopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195616;

    /// <inheritdoc />
    public virtual string GenusName => "Isopsetta";

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
