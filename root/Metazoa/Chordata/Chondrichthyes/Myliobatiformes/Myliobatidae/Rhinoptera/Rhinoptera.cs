using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Myliobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Myliobatidae.Rhinoptera;

/// <summary>
/// Abstract class for Rhinoptera (genus).
/// NCBI TaxId: 86374
/// </summary>
public abstract class Rhinoptera : Myliobatidae, IRhinoptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinoptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86374;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinoptera";

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
