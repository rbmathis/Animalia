using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Pseudois;

/// <summary>
/// Abstract class for Pseudois (genus).
/// NCBI TaxId: 59541
/// </summary>
public abstract class Pseudois : Bovidae, IPseudois
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudois";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59541;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudois";

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
