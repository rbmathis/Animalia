using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Eopsetta;

/// <summary>
/// Abstract class for Eopsetta (genus).
/// NCBI TaxId: 195608
/// </summary>
public abstract class Eopsetta : Pleuronectidae, IEopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195608;

    /// <inheritdoc />
    public virtual string GenusName => "Eopsetta";

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
