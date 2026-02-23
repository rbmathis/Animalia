using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Thayeria;

/// <summary>
/// Abstract class for Thayeria (genus).
/// NCBI TaxId: 272072
/// </summary>
public abstract class Thayeria : Characidae, IThayeria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thayeria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 272072;

    /// <inheritdoc />
    public virtual string GenusName => "Thayeria";

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
