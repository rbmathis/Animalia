using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Myzopsetta;

/// <summary>
/// Abstract class for Myzopsetta (genus).
/// NCBI TaxId: 2135392
/// </summary>
public abstract class Myzopsetta : Pleuronectidae, IMyzopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myzopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2135392;

    /// <inheritdoc />
    public virtual string GenusName => "Myzopsetta";

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
