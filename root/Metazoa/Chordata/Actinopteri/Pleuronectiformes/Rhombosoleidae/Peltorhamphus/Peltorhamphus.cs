using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae.Peltorhamphus;

/// <summary>
/// Abstract class for Peltorhamphus (genus).
/// NCBI TaxId: 526619
/// </summary>
public abstract class Peltorhamphus : Rhombosoleidae, IPeltorhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Peltorhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 526619;

    /// <inheritdoc />
    public virtual string GenusName => "Peltorhamphus";

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
