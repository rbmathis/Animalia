using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Hemidactylium;

/// <summary>
/// Abstract class for Hemidactylium (genus).
/// NCBI TaxId: 269187
/// </summary>
public abstract class Hemidactylium : Plethodontidae, IHemidactylium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemidactylium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 269187;

    /// <inheritdoc />
    public virtual string GenusName => "Hemidactylium";

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
