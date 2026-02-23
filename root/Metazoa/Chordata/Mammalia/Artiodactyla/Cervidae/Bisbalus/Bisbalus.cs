using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Bisbalus;

/// <summary>
/// Abstract class for Bisbalus (genus).
/// NCBI TaxId: 3127177
/// </summary>
public abstract class Bisbalus : Cervidae, IBisbalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bisbalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3127177;

    /// <inheritdoc />
    public virtual string GenusName => "Bisbalus";

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
