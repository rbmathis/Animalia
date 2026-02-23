using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Liopsetta;

/// <summary>
/// Abstract class for Liopsetta (genus).
/// NCBI TaxId: 382949
/// </summary>
public abstract class Liopsetta : Pleuronectidae, ILiopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 382949;

    /// <inheritdoc />
    public virtual string GenusName => "Liopsetta";

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
