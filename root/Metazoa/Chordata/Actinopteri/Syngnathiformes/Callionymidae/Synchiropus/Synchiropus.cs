using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Synchiropus;

/// <summary>
/// Abstract class for Synchiropus (genus).
/// NCBI TaxId: 215387
/// </summary>
public abstract class Synchiropus : Callionymidae, ISynchiropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Synchiropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215387;

    /// <inheritdoc />
    public virtual string GenusName => "Synchiropus";

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
