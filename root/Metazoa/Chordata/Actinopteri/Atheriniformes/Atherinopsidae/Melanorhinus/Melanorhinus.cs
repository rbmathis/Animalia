using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Melanorhinus;

/// <summary>
/// Abstract class for Melanorhinus (genus).
/// NCBI TaxId: 1144223
/// </summary>
public abstract class Melanorhinus : Atherinopsidae, IMelanorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1144223;

    /// <inheritdoc />
    public virtual string GenusName => "Melanorhinus";

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
