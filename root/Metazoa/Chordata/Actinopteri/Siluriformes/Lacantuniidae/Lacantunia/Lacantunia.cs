using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Lacantuniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Lacantuniidae.Lacantunia;

/// <summary>
/// Abstract class for Lacantunia (genus).
/// NCBI TaxId: 409305
/// </summary>
public abstract class Lacantunia : Lacantuniidae, ILacantunia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lacantunia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 409305;

    /// <inheritdoc />
    public virtual string GenusName => "Lacantunia";

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
