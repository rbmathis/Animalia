using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Aphyonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Aphyonidae.Paraphyonus;

/// <summary>
/// Abstract class for Paraphyonus (genus).
/// NCBI TaxId: 2590967
/// </summary>
public abstract class Paraphyonus : Aphyonidae, IParaphyonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraphyonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2590967;

    /// <inheritdoc />
    public virtual string GenusName => "Paraphyonus";

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
