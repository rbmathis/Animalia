using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Hemitrygon;

/// <summary>
/// Abstract class for Hemitrygon (genus).
/// NCBI TaxId: 2093253
/// </summary>
public abstract class Hemitrygon : Dasyatidae, IHemitrygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemitrygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2093253;

    /// <inheritdoc />
    public virtual string GenusName => "Hemitrygon";

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
