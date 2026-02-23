using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Himantura;

/// <summary>
/// Abstract class for Himantura (genus).
/// NCBI TaxId: 86362
/// </summary>
public abstract class Himantura : Dasyatidae, IHimantura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Himantura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86362;

    /// <inheritdoc />
    public virtual string GenusName => "Himantura";

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
