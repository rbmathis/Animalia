using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Taaningichthys;

/// <summary>
/// Abstract class for Taaningichthys (genus).
/// NCBI TaxId: 123248
/// </summary>
public abstract class Taaningichthys : Myctophidae, ITaaningichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taaningichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123248;

    /// <inheritdoc />
    public virtual string GenusName => "Taaningichthys";

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
