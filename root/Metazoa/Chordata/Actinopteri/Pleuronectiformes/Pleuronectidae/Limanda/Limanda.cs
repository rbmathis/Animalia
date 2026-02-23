using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Limanda;

/// <summary>
/// Abstract class for Limanda (genus).
/// NCBI TaxId: 8257
/// </summary>
public abstract class Limanda : Pleuronectidae, ILimanda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Limanda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8257;

    /// <inheritdoc />
    public virtual string GenusName => "Limanda";

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
