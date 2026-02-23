using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Bathyraja;

/// <summary>
/// Abstract class for Bathyraja (genus).
/// NCBI TaxId: 117870
/// </summary>
public abstract class Bathyraja : Arhynchobatidae, IBathyraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathyraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117870;

    /// <inheritdoc />
    public virtual string GenusName => "Bathyraja";

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
