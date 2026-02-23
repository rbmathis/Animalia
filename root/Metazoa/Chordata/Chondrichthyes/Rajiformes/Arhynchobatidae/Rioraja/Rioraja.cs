using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Rioraja;

/// <summary>
/// Abstract class for Rioraja (genus).
/// NCBI TaxId: 117877
/// </summary>
public abstract class Rioraja : Arhynchobatidae, IRioraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rioraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117877;

    /// <inheritdoc />
    public virtual string GenusName => "Rioraja";

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
