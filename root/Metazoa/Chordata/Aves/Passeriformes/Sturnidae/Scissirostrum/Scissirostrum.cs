using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Scissirostrum;

/// <summary>
/// Abstract class for Scissirostrum (genus).
/// NCBI TaxId: 241744
/// </summary>
public abstract class Scissirostrum : Sturnidae, IScissirostrum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scissirostrum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241744;

    /// <inheritdoc />
    public virtual string GenusName => "Scissirostrum";

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
