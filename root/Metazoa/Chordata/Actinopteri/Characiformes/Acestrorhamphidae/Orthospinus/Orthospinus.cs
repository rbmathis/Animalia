using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Orthospinus;

/// <summary>
/// Abstract class for Orthospinus (genus).
/// NCBI TaxId: 930362
/// </summary>
public abstract class Orthospinus : Acestrorhamphidae, IOrthospinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orthospinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930362;

    /// <inheritdoc />
    public virtual string GenusName => "Orthospinus";

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
