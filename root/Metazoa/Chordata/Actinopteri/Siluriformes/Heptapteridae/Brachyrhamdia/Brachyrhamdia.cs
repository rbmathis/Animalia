using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Brachyrhamdia;

/// <summary>
/// Abstract class for Brachyrhamdia (genus).
/// NCBI TaxId: 337806
/// </summary>
public abstract class Brachyrhamdia : Heptapteridae, IBrachyrhamdia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachyrhamdia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337806;

    /// <inheritdoc />
    public virtual string GenusName => "Brachyrhamdia";

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
