using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Acanthopsetta;

/// <summary>
/// Abstract class for Acanthopsetta (genus).
/// NCBI TaxId: 352242
/// </summary>
public abstract class Acanthopsetta : Pleuronectidae, IAcanthopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 352242;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthopsetta";

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
