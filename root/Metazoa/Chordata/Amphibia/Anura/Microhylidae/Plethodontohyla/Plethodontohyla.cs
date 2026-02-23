using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Plethodontohyla;

/// <summary>
/// Abstract class for Plethodontohyla (genus).
/// NCBI TaxId: 143637
/// </summary>
public abstract class Plethodontohyla : Microhylidae, IPlethodontohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plethodontohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143637;

    /// <inheritdoc />
    public virtual string GenusName => "Plethodontohyla";

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
