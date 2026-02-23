using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae.Seriolella;

/// <summary>
/// Abstract class for Seriolella (genus).
/// NCBI TaxId: 316133
/// </summary>
public abstract class Seriolella : Centrolophidae, ISeriolella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Seriolella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 316133;

    /// <inheritdoc />
    public virtual string GenusName => "Seriolella";

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
