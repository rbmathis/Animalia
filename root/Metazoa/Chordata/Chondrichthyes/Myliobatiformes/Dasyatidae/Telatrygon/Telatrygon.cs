using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Telatrygon;

/// <summary>
/// Abstract class for Telatrygon (genus).
/// NCBI TaxId: 1930091
/// </summary>
public abstract class Telatrygon : Dasyatidae, ITelatrygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Telatrygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1930091;

    /// <inheritdoc />
    public virtual string GenusName => "Telatrygon";

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
