using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bootherium;

/// <summary>
/// Abstract class for Bootherium (genus).
/// NCBI TaxId: 1922214
/// </summary>
public abstract class Bootherium : Bovidae, IBootherium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bootherium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1922214;

    /// <inheritdoc />
    public virtual string GenusName => "Bootherium";

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
