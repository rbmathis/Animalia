using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zenionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zenionidae.Zenion;

/// <summary>
/// Abstract class for Zenion (genus).
/// NCBI TaxId: 181442
/// </summary>
public abstract class Zenion : Zenionidae, IZenion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zenion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181442;

    /// <inheritdoc />
    public virtual string GenusName => "Zenion";

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
