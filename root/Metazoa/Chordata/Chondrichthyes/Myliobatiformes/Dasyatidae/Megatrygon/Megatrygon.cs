using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Dasyatidae.Megatrygon;

/// <summary>
/// Abstract class for Megatrygon (genus).
/// NCBI TaxId: 3362330
/// </summary>
public abstract class Megatrygon : Dasyatidae, IMegatrygon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megatrygon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362330;

    /// <inheritdoc />
    public virtual string GenusName => "Megatrygon";

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
