using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Gastroscyphus;

/// <summary>
/// Abstract class for Gastroscyphus (genus).
/// NCBI TaxId: 2740768
/// </summary>
public abstract class Gastroscyphus : Gobiesocidae, IGastroscyphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gastroscyphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2740768;

    /// <inheritdoc />
    public virtual string GenusName => "Gastroscyphus";

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
