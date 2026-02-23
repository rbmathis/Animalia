using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Aquiloeurycea;

/// <summary>
/// Abstract class for Aquiloeurycea (genus).
/// NCBI TaxId: 1709089
/// </summary>
public abstract class Aquiloeurycea : Plethodontidae, IAquiloeurycea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aquiloeurycea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1709089;

    /// <inheritdoc />
    public virtual string GenusName => "Aquiloeurycea";

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
