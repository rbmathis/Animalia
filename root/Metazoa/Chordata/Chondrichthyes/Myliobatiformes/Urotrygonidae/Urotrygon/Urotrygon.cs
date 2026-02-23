using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Urotrygonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Urotrygonidae.Urotrygon;

/// <summary>
/// Abstract class for Urotrygon (genus).
/// NCBI TaxId: 117838
/// </summary>
public abstract class Urotrygon : Urotrygonidae, IUrotrygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urotrygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117838;

    /// <inheritdoc />
    public virtual string GenusName => "Urotrygon";

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
