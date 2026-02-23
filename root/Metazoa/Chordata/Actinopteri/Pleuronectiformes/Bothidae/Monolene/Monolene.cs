using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Monolene;

/// <summary>
/// Abstract class for Monolene (genus).
/// NCBI TaxId: 1266885
/// </summary>
public abstract class Monolene : Bothidae, IMonolene
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monolene";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1266885;

    /// <inheritdoc />
    public virtual string GenusName => "Monolene";

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
