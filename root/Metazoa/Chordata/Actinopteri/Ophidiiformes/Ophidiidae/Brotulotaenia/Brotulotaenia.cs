using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Brotulotaenia;

/// <summary>
/// Abstract class for Brotulotaenia (genus).
/// NCBI TaxId: 443754
/// </summary>
public abstract class Brotulotaenia : Ophidiidae, IBrotulotaenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brotulotaenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443754;

    /// <inheritdoc />
    public virtual string GenusName => "Brotulotaenia";

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
