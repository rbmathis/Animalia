using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae.Ziphius;

/// <summary>
/// Abstract class for Ziphius (genus).
/// NCBI TaxId: 9759
/// </summary>
public abstract class Ziphius : Ziphiidae, IZiphius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ziphius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9759;

    /// <inheritdoc />
    public virtual string GenusName => "Ziphius";

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
