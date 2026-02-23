using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Saiga;

/// <summary>
/// Abstract class for Saiga (genus).
/// NCBI TaxId: 34874
/// </summary>
public abstract class Saiga : Bovidae, ISaiga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saiga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34874;

    /// <inheritdoc />
    public virtual string GenusName => "Saiga";

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
