using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Mertensophryne;

/// <summary>
/// Abstract class for Mertensophryne (genus).
/// NCBI TaxId: 420447
/// </summary>
public abstract class Mertensophryne : Bufonidae, IMertensophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mertensophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 420447;

    /// <inheritdoc />
    public virtual string GenusName => "Mertensophryne";

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
