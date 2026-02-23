using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Bathytoshia;

/// <summary>
/// Abstract class for Bathytoshia (genus).
/// NCBI TaxId: 2484684
/// </summary>
public abstract class Bathytoshia : Dasyatidae, IBathytoshia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathytoshia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2484684;

    /// <inheritdoc />
    public virtual string GenusName => "Bathytoshia";

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
