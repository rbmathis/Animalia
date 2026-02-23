using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Urolophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Urolophidae.Trygonoptera;

/// <summary>
/// Abstract class for Trygonoptera (genus).
/// NCBI TaxId: 443772
/// </summary>
public abstract class Trygonoptera : Urolophidae, ITrygonoptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trygonoptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443772;

    /// <inheritdoc />
    public virtual string GenusName => "Trygonoptera";

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
