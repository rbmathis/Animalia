using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenopteridae.Balaenoptera;

/// <summary>
/// Abstract class for Balaenoptera (genus).
/// NCBI TaxId: 9766
/// </summary>
public abstract class Balaenoptera : Balaenopteridae, IBalaenoptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Balaenoptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9766;

    /// <inheritdoc />
    public virtual string GenusName => "Balaenoptera";

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
