using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Antrozous;

/// <summary>
/// Abstract class for Antrozous (genus).
/// NCBI TaxId: 9439
/// </summary>
public abstract class Antrozous : Vespertilionidae, IAntrozous
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Antrozous";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9439;

    /// <inheritdoc />
    public virtual string GenusName => "Antrozous";

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
