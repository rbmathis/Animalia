using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Hydromantes;

/// <summary>
/// Abstract class for Hydromantes (genus).
/// NCBI TaxId: 36316
/// </summary>
public abstract class Hydromantes : Plethodontidae, IHydromantes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydromantes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36316;

    /// <inheritdoc />
    public virtual string GenusName => "Hydromantes";

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
