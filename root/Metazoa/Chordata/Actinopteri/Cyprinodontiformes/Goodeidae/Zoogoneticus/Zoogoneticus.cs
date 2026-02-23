using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Zoogoneticus;

/// <summary>
/// Abstract class for Zoogoneticus (genus).
/// NCBI TaxId: 28763
/// </summary>
public abstract class Zoogoneticus : Goodeidae, IZoogoneticus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zoogoneticus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28763;

    /// <inheritdoc />
    public virtual string GenusName => "Zoogoneticus";

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
