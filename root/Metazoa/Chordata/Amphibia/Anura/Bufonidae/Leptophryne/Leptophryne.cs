using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Leptophryne;

/// <summary>
/// Abstract class for Leptophryne (genus).
/// NCBI TaxId: 420445
/// </summary>
public abstract class Leptophryne : Bufonidae, ILeptophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 420445;

    /// <inheritdoc />
    public virtual string GenusName => "Leptophryne";

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
