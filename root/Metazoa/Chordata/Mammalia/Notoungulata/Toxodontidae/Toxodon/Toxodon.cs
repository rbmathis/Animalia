using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Notoungulata.Toxodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Notoungulata.Toxodontidae.Toxodon;

/// <summary>
/// Abstract class for Toxodon (genus).
/// NCBI TaxId: 1563121
/// </summary>
public abstract class Toxodon : Toxodontidae, IToxodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Toxodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1563121;

    /// <inheritdoc />
    public virtual string GenusName => "Toxodon";

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
