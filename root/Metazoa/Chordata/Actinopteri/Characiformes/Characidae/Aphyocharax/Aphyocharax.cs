using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Aphyocharax;

/// <summary>
/// Abstract class for Aphyocharax (genus).
/// NCBI TaxId: 42588
/// </summary>
public abstract class Aphyocharax : Characidae, IAphyocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphyocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42588;

    /// <inheritdoc />
    public virtual string GenusName => "Aphyocharax";

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
