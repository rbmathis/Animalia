using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Cryptocentroides;

/// <summary>
/// Abstract class for Cryptocentroides (genus).
/// NCBI TaxId: 512334
/// </summary>
public abstract class Cryptocentroides : Gobiidae, ICryptocentroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptocentroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 512334;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptocentroides";

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
