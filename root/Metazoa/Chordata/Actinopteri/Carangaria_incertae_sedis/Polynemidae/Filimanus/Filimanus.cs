using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae.Filimanus;

/// <summary>
/// Abstract class for Filimanus (genus).
/// NCBI TaxId: 445364
/// </summary>
public abstract class Filimanus : Polynemidae, IFilimanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Filimanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 445364;

    /// <inheritdoc />
    public virtual string GenusName => "Filimanus";

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
