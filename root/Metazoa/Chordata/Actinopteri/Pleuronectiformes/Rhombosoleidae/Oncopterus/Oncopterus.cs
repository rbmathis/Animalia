using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae.Oncopterus;

/// <summary>
/// Abstract class for Oncopterus (genus).
/// NCBI TaxId: 1286172
/// </summary>
public abstract class Oncopterus : Rhombosoleidae, IOncopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oncopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1286172;

    /// <inheritdoc />
    public virtual string GenusName => "Oncopterus";

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
