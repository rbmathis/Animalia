using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Flexor;

/// <summary>
/// Abstract class for Flexor (genus).
/// NCBI TaxId: 2740784
/// </summary>
public abstract class Flexor : Gobiesocidae, IFlexor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Flexor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2740784;

    /// <inheritdoc />
    public virtual string GenusName => "Flexor";

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
