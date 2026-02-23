using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Chalinops;

/// <summary>
/// Abstract class for Chalinops (genus).
/// NCBI TaxId: 3363398
/// </summary>
public abstract class Chalinops : Callionymidae, IChalinops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chalinops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363398;

    /// <inheritdoc />
    public virtual string GenusName => "Chalinops";

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
