using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Ensatina;

/// <summary>
/// Abstract class for Ensatina (genus).
/// NCBI TaxId: 57549
/// </summary>
public abstract class Ensatina : Plethodontidae, IEnsatina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ensatina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57549;

    /// <inheritdoc />
    public virtual string GenusName => "Ensatina";

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
