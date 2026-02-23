using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Roeboexodon;

/// <summary>
/// Abstract class for Roeboexodon (genus).
/// NCBI TaxId: 930394
/// </summary>
public abstract class Roeboexodon : Characidae, IRoeboexodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Roeboexodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930394;

    /// <inheritdoc />
    public virtual string GenusName => "Roeboexodon";

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
