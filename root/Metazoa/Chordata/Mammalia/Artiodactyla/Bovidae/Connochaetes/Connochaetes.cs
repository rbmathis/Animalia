using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Connochaetes;

/// <summary>
/// Abstract class for Connochaetes (genus).
/// NCBI TaxId: 9926
/// </summary>
public abstract class Connochaetes : Bovidae, IConnochaetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Connochaetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9926;

    /// <inheritdoc />
    public virtual string GenusName => "Connochaetes";

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
