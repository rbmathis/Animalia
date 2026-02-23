using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Bolitoglossa;

/// <summary>
/// Abstract class for Bolitoglossa (genus).
/// NCBI TaxId: 8333
/// </summary>
public abstract class Bolitoglossa : Plethodontidae, IBolitoglossa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bolitoglossa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8333;

    /// <inheritdoc />
    public virtual string GenusName => "Bolitoglossa";

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
