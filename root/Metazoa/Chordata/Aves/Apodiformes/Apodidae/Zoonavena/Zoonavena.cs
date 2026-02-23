using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Zoonavena;

/// <summary>
/// Abstract class for Zoonavena (genus).
/// NCBI TaxId: 3092327
/// </summary>
public abstract class Zoonavena : Apodidae, IZoonavena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zoonavena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3092327;

    /// <inheritdoc />
    public virtual string GenusName => "Zoonavena";

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
