using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Tincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Tincidae.Tinca;

/// <summary>
/// Abstract class for Tinca (genus).
/// NCBI TaxId: 27716
/// </summary>
public abstract class Tinca : Tincidae, ITinca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tinca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27716;

    /// <inheritdoc />
    public virtual string GenusName => "Tinca";

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
