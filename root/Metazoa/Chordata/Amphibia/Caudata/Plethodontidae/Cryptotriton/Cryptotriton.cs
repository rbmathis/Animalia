using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Cryptotriton;

/// <summary>
/// Abstract class for Cryptotriton (genus).
/// NCBI TaxId: 107963
/// </summary>
public abstract class Cryptotriton : Plethodontidae, ICryptotriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptotriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107963;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptotriton";

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
