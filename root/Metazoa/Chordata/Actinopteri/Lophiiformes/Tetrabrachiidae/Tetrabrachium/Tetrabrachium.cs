using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Tetrabrachiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Tetrabrachiidae.Tetrabrachium;

/// <summary>
/// Abstract class for Tetrabrachium (genus).
/// NCBI TaxId: 242971
/// </summary>
public abstract class Tetrabrachium : Tetrabrachiidae, ITetrabrachium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tetrabrachium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 242971;

    /// <inheritdoc />
    public virtual string GenusName => "Tetrabrachium";

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
