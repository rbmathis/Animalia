using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Taeniopsetta;

/// <summary>
/// Abstract class for Taeniopsetta (genus).
/// NCBI TaxId: 398645
/// </summary>
public abstract class Taeniopsetta : Bothidae, ITaeniopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taeniopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 398645;

    /// <inheritdoc />
    public virtual string GenusName => "Taeniopsetta";

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
