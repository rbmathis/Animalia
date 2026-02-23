using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Stenobrachius;

/// <summary>
/// Abstract class for Stenobrachius (genus).
/// NCBI TaxId: 91657
/// </summary>
public abstract class Stenobrachius : Myctophidae, IStenobrachius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stenobrachius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91657;

    /// <inheritdoc />
    public virtual string GenusName => "Stenobrachius";

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
