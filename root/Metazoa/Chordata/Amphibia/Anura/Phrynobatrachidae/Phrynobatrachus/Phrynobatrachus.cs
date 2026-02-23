using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Phrynobatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Phrynobatrachidae.Phrynobatrachus;

/// <summary>
/// Abstract class for Phrynobatrachus (genus).
/// NCBI TaxId: 143461
/// </summary>
public abstract class Phrynobatrachus : Phrynobatrachidae, IPhrynobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phrynobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143461;

    /// <inheritdoc />
    public virtual string GenusName => "Phrynobatrachus";

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
