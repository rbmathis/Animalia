using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Hexatrygonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Hexatrygonidae.Hexatrygon;

/// <summary>
/// Abstract class for Hexatrygon (genus).
/// NCBI TaxId: 117843
/// </summary>
public abstract class Hexatrygon : Hexatrygonidae, IHexatrygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hexatrygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117843;

    /// <inheritdoc />
    public virtual string GenusName => "Hexatrygon";

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
