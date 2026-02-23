using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Rhinoraja;

/// <summary>
/// Abstract class for Rhinoraja (genus).
/// NCBI TaxId: 117876
/// </summary>
public abstract class Rhinoraja : Arhynchobatidae, IRhinoraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinoraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117876;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinoraja";

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
