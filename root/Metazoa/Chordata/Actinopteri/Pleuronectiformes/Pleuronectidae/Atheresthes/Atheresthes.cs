using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Atheresthes;

/// <summary>
/// Abstract class for Atheresthes (genus).
/// NCBI TaxId: 428033
/// </summary>
public abstract class Atheresthes : Pleuronectidae, IAtheresthes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atheresthes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 428033;

    /// <inheritdoc />
    public virtual string GenusName => "Atheresthes";

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
