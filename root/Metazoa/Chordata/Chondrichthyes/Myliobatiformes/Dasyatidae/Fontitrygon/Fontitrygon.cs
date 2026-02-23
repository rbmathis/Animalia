using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Fontitrygon;

/// <summary>
/// Abstract class for Fontitrygon (genus).
/// NCBI TaxId: 2292421
/// </summary>
public abstract class Fontitrygon : Dasyatidae, IFontitrygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fontitrygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2292421;

    /// <inheritdoc />
    public virtual string GenusName => "Fontitrygon";

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
