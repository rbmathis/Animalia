using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Kopua;

/// <summary>
/// Abstract class for Kopua (genus).
/// NCBI TaxId: 2608477
/// </summary>
public abstract class Kopua : Gobiesocidae, IKopua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kopua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608477;

    /// <inheritdoc />
    public virtual string GenusName => "Kopua";

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
