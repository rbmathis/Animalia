using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenopteridae.Megaptera;

/// <summary>
/// Abstract class for Megaptera (genus).
/// NCBI TaxId: 9772
/// </summary>
public abstract class Megaptera : Balaenopteridae, IMegaptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megaptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9772;

    /// <inheritdoc />
    public virtual string GenusName => "Megaptera";

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
