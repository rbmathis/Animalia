using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Karsenia;

/// <summary>
/// Abstract class for Karsenia (genus).
/// NCBI TaxId: 322012
/// </summary>
public abstract class Karsenia : Plethodontidae, IKarsenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Karsenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 322012;

    /// <inheritdoc />
    public virtual string GenusName => "Karsenia";

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
