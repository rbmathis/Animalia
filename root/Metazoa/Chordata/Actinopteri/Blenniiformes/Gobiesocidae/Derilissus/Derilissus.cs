using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Derilissus;

/// <summary>
/// Abstract class for Derilissus (genus).
/// NCBI TaxId: 2740788
/// </summary>
public abstract class Derilissus : Gobiesocidae, IDerilissus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Derilissus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2740788;

    /// <inheritdoc />
    public virtual string GenusName => "Derilissus";

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
