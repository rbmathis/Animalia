using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Apletodon;

/// <summary>
/// Abstract class for Apletodon (genus).
/// NCBI TaxId: 206116
/// </summary>
public abstract class Apletodon : Gobiesocidae, IApletodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apletodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206116;

    /// <inheritdoc />
    public virtual string GenusName => "Apletodon";

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
