using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Brachyglanis;

/// <summary>
/// Abstract class for Brachyglanis (genus).
/// NCBI TaxId: 2821903
/// </summary>
public abstract class Brachyglanis : Heptapteridae, IBrachyglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachyglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821903;

    /// <inheritdoc />
    public virtual string GenusName => "Brachyglanis";

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
