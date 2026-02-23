using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Urotrygonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Urotrygonidae.Urobatis;

/// <summary>
/// Abstract class for Urobatis (genus).
/// NCBI TaxId: 86674
/// </summary>
public abstract class Urobatis : Urotrygonidae, IUrobatis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urobatis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86674;

    /// <inheritdoc />
    public virtual string GenusName => "Urobatis";

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
