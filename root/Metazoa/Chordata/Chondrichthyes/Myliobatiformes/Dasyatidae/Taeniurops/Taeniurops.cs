using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Taeniurops;

/// <summary>
/// Abstract class for Taeniurops (genus).
/// NCBI TaxId: 3342087
/// </summary>
public abstract class Taeniurops : Dasyatidae, ITaeniurops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taeniurops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3342087;

    /// <inheritdoc />
    public virtual string GenusName => "Taeniurops";

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
