using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenidae.Balaena;

/// <summary>
/// Abstract class for Balaena (genus).
/// NCBI TaxId: 27601
/// </summary>
public abstract class Balaena : Balaenidae, IBalaena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Balaena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27601;

    /// <inheritdoc />
    public virtual string GenusName => "Balaena";

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
