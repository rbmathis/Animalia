using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae.Berardius;

/// <summary>
/// Abstract class for Berardius (genus).
/// NCBI TaxId: 48741
/// </summary>
public abstract class Berardius : Ziphiidae, IBerardius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Berardius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48741;

    /// <inheritdoc />
    public virtual string GenusName => "Berardius";

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
