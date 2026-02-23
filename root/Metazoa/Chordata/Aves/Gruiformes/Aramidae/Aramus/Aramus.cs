using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Aramidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Aramidae.Aramus;

/// <summary>
/// Abstract class for Aramus (genus).
/// NCBI TaxId: 54355
/// </summary>
public abstract class Aramus : Aramidae, IAramus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aramus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54355;

    /// <inheritdoc />
    public virtual string GenusName => "Aramus";

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
