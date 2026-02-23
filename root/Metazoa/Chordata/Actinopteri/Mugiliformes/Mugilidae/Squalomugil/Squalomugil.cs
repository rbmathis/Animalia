using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Squalomugil;

/// <summary>
/// Abstract class for Squalomugil (genus).
/// NCBI TaxId: 1935937
/// </summary>
public abstract class Squalomugil : Mugilidae, ISqualomugil
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Squalomugil";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1935937;

    /// <inheritdoc />
    public virtual string GenusName => "Squalomugil";

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
