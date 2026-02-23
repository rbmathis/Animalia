using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenidae.Eubalaena;

/// <summary>
/// Abstract class for Eubalaena (genus).
/// NCBI TaxId: 27605
/// </summary>
public abstract class Eubalaena : Balaenidae, IEubalaena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eubalaena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27605;

    /// <inheritdoc />
    public virtual string GenusName => "Eubalaena";

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
