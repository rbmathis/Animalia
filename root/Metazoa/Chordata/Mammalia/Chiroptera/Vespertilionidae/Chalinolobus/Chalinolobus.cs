using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Chalinolobus;

/// <summary>
/// Abstract class for Chalinolobus (genus).
/// NCBI TaxId: 50352
/// </summary>
public abstract class Chalinolobus : Vespertilionidae, IChalinolobus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chalinolobus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50352;

    /// <inheritdoc />
    public virtual string GenusName => "Chalinolobus";

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
