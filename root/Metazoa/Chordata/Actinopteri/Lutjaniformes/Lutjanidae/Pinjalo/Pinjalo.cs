using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Pinjalo;

/// <summary>
/// Abstract class for Pinjalo (genus).
/// NCBI TaxId: 264215
/// </summary>
public abstract class Pinjalo : Lutjanidae, IPinjalo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pinjalo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 264215;

    /// <inheritdoc />
    public virtual string GenusName => "Pinjalo";

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
