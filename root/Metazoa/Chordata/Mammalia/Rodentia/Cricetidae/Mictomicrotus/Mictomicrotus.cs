using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Mictomicrotus;

/// <summary>
/// Abstract class for Mictomicrotus (genus).
/// NCBI TaxId: 3371078
/// </summary>
public abstract class Mictomicrotus : Cricetidae, IMictomicrotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mictomicrotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3371078;

    /// <inheritdoc />
    public virtual string GenusName => "Mictomicrotus";

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
