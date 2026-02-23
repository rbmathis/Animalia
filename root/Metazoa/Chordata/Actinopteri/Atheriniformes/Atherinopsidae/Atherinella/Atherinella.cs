using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Atherinella;

/// <summary>
/// Abstract class for Atherinella (genus).
/// NCBI TaxId: 300301
/// </summary>
public abstract class Atherinella : Atherinopsidae, IAtherinella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atherinella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 300301;

    /// <inheritdoc />
    public virtual string GenusName => "Atherinella";

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
