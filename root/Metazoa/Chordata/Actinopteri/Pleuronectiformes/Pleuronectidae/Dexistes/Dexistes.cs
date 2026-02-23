using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Dexistes;

/// <summary>
/// Abstract class for Dexistes (genus).
/// NCBI TaxId: 641116
/// </summary>
public abstract class Dexistes : Pleuronectidae, IDexistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dexistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 641116;

    /// <inheritdoc />
    public virtual string GenusName => "Dexistes";

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
