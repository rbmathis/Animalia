using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Atherinops;

/// <summary>
/// Abstract class for Atherinops (genus).
/// NCBI TaxId: 238740
/// </summary>
public abstract class Atherinops : Atherinopsidae, IAtherinops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atherinops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238740;

    /// <inheritdoc />
    public virtual string GenusName => "Atherinops";

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
