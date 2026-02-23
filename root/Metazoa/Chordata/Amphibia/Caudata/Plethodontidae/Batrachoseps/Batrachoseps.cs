using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Batrachoseps;

/// <summary>
/// Abstract class for Batrachoseps (genus).
/// NCBI TaxId: 57542
/// </summary>
public abstract class Batrachoseps : Plethodontidae, IBatrachoseps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Batrachoseps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57542;

    /// <inheritdoc />
    public virtual string GenusName => "Batrachoseps";

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
