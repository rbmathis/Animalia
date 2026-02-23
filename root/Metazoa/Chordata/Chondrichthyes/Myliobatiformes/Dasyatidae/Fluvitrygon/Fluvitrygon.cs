using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Fluvitrygon;

/// <summary>
/// Abstract class for Fluvitrygon (genus).
/// NCBI TaxId: 2338057
/// </summary>
public abstract class Fluvitrygon : Dasyatidae, IFluvitrygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fluvitrygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2338057;

    /// <inheritdoc />
    public virtual string GenusName => "Fluvitrygon";

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
