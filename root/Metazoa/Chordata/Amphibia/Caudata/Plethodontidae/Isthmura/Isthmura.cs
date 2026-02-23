using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Isthmura;

/// <summary>
/// Abstract class for Isthmura (genus).
/// NCBI TaxId: 1709198
/// </summary>
public abstract class Isthmura : Plethodontidae, IIsthmura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Isthmura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1709198;

    /// <inheritdoc />
    public virtual string GenusName => "Isthmura";

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
