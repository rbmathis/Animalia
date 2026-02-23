using AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Upupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Upupidae.Upupa;

/// <summary>
/// Abstract class for Upupa (genus).
/// NCBI TaxId: 57438
/// </summary>
public abstract class Upupa : Upupidae, IUpupa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Upupa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57438;

    /// <inheritdoc />
    public virtual string GenusName => "Upupa";

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
