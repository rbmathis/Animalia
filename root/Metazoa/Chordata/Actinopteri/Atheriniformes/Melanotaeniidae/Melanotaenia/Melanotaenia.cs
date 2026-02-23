using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Melanotaeniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Melanotaeniidae.Melanotaenia;

/// <summary>
/// Abstract class for Melanotaenia (genus).
/// NCBI TaxId: 32459
/// </summary>
public abstract class Melanotaenia : Melanotaeniidae, IMelanotaenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanotaenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32459;

    /// <inheritdoc />
    public virtual string GenusName => "Melanotaenia";

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
