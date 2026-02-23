using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Haplocylix;

/// <summary>
/// Abstract class for Haplocylix (genus).
/// NCBI TaxId: 2740766
/// </summary>
public abstract class Haplocylix : Gobiesocidae, IHaplocylix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haplocylix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2740766;

    /// <inheritdoc />
    public virtual string GenusName => "Haplocylix";

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
