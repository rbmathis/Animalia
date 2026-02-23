using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Addax;

/// <summary>
/// Abstract class for Addax (genus).
/// NCBI TaxId: 59514
/// </summary>
public abstract class Addax : Bovidae, IAddax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Addax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59514;

    /// <inheritdoc />
    public virtual string GenusName => "Addax";

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
