using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Satanoperca;

/// <summary>
/// Abstract class for Satanoperca (genus).
/// NCBI TaxId: 61806
/// </summary>
public abstract class Satanoperca : Cichlidae, ISatanoperca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Satanoperca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61806;

    /// <inheritdoc />
    public virtual string GenusName => "Satanoperca";

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
