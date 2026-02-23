using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Menidia;

/// <summary>
/// Abstract class for Menidia (genus).
/// NCBI TaxId: 238743
/// </summary>
public abstract class Menidia : Atherinopsidae, IMenidia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Menidia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238743;

    /// <inheritdoc />
    public virtual string GenusName => "Menidia";

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
