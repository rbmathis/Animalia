using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cyclopsettidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Cyclopsettidae.Syacium;

/// <summary>
/// Abstract class for Syacium (genus).
/// NCBI TaxId: 195648
/// </summary>
public abstract class Syacium : Cyclopsettidae, ISyacium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Syacium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195648;

    /// <inheritdoc />
    public virtual string GenusName => "Syacium";

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
