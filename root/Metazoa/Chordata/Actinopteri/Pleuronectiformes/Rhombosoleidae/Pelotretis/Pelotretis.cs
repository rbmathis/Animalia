using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae.Pelotretis;

/// <summary>
/// Abstract class for Pelotretis (genus).
/// NCBI TaxId: 526617
/// </summary>
public abstract class Pelotretis : Rhombosoleidae, IPelotretis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelotretis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 526617;

    /// <inheritdoc />
    public virtual string GenusName => "Pelotretis";

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
