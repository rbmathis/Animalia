using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Lyopsetta;

/// <summary>
/// Abstract class for Lyopsetta (genus).
/// NCBI TaxId: 195625
/// </summary>
public abstract class Lyopsetta : Pleuronectidae, ILyopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lyopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195625;

    /// <inheritdoc />
    public virtual string GenusName => "Lyopsetta";

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
