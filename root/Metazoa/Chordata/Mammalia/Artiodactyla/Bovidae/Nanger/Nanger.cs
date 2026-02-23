using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Nanger;

/// <summary>
/// Abstract class for Nanger (genus).
/// NCBI TaxId: 457560
/// </summary>
public abstract class Nanger : Bovidae, INanger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nanger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 457560;

    /// <inheritdoc />
    public virtual string GenusName => "Nanger";

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
