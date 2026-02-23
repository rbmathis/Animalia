using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Eurycea;

/// <summary>
/// Abstract class for Eurycea (genus).
/// NCBI TaxId: 43043
/// </summary>
public abstract class Eurycea : Plethodontidae, IEurycea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eurycea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43043;

    /// <inheritdoc />
    public virtual string GenusName => "Eurycea";

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
