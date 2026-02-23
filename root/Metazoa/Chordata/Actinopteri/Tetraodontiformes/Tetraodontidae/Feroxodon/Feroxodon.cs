using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Feroxodon;

/// <summary>
/// Abstract class for Feroxodon (genus).
/// NCBI TaxId: 2578380
/// </summary>
public abstract class Feroxodon : Tetraodontidae, IFeroxodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Feroxodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2578380;

    /// <inheritdoc />
    public virtual string GenusName => "Feroxodon";

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
