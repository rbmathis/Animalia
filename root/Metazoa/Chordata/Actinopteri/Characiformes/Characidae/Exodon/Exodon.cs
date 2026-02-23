using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Exodon;

/// <summary>
/// Abstract class for Exodon (genus).
/// NCBI TaxId: 304004
/// </summary>
public abstract class Exodon : Characidae, IExodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Exodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304004;

    /// <inheritdoc />
    public virtual string GenusName => "Exodon";

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
