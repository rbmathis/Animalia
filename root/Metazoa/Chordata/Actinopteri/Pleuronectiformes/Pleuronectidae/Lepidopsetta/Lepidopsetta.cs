using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Lepidopsetta;

/// <summary>
/// Abstract class for Lepidopsetta (genus).
/// NCBI TaxId: 195622
/// </summary>
public abstract class Lepidopsetta : Pleuronectidae, ILepidopsetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidopsetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195622;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidopsetta";

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
