using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Proteidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Proteidae.Proteus;

/// <summary>
/// Abstract class for Proteus (genus).
/// NCBI TaxId: 210425
/// </summary>
public abstract class Proteus : Proteidae, IProteus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Proteus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210425;

    /// <inheritdoc />
    public virtual string GenusName => "Proteus";

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
