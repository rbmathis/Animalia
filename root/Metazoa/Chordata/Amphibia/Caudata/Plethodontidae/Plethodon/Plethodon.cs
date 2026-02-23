using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Plethodon;

/// <summary>
/// Abstract class for Plethodon (genus).
/// NCBI TaxId: 8335
/// </summary>
public abstract class Plethodon : Plethodontidae, IPlethodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plethodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8335;

    /// <inheritdoc />
    public virtual string GenusName => "Plethodon";

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
