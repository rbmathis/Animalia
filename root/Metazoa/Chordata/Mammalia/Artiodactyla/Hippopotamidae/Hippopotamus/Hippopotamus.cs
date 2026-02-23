using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Hippopotamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Hippopotamidae.Hippopotamus;

/// <summary>
/// Abstract class for Hippopotamus (genus).
/// NCBI TaxId: 9832
/// </summary>
public abstract class Hippopotamus : Hippopotamidae, IHippopotamus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hippopotamus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9832;

    /// <inheritdoc />
    public virtual string GenusName => "Hippopotamus";

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
