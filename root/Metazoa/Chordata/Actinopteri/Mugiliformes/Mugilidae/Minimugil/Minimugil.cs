using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Minimugil;

/// <summary>
/// Abstract class for Minimugil (genus).
/// NCBI TaxId: 1935939
/// </summary>
public abstract class Minimugil : Mugilidae, IMinimugil
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Minimugil";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1935939;

    /// <inheritdoc />
    public virtual string GenusName => "Minimugil";

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
