using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Priocharax;

/// <summary>
/// Abstract class for Priocharax (genus).
/// NCBI TaxId: 2608217
/// </summary>
public abstract class Priocharax : Acestrorhamphidae, IPriocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Priocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608217;

    /// <inheritdoc />
    public virtual string GenusName => "Priocharax";

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
