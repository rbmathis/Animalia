using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Gracilimugil;

/// <summary>
/// Abstract class for Gracilimugil (genus).
/// NCBI TaxId: 1935938
/// </summary>
public abstract class Gracilimugil : Mugilidae, IGracilimugil
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gracilimugil";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1935938;

    /// <inheritdoc />
    public virtual string GenusName => "Gracilimugil";

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
