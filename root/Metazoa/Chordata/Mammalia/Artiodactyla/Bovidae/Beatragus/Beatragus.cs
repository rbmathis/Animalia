using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Beatragus;

/// <summary>
/// Abstract class for Beatragus (genus).
/// NCBI TaxId: 59526
/// </summary>
public abstract class Beatragus : Bovidae, IBeatragus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Beatragus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59526;

    /// <inheritdoc />
    public virtual string GenusName => "Beatragus";

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
