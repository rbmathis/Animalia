using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Myliobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Myliobatidae.Myliobatis;

/// <summary>
/// Abstract class for Myliobatis (genus).
/// NCBI TaxId: 55137
/// </summary>
public abstract class Myliobatis : Myliobatidae, IMyliobatis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myliobatis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55137;

    /// <inheritdoc />
    public virtual string GenusName => "Myliobatis";

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
