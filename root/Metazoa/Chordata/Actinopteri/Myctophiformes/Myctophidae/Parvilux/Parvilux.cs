using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Parvilux;

/// <summary>
/// Abstract class for Parvilux (genus).
/// NCBI TaxId: 717804
/// </summary>
public abstract class Parvilux : Myctophidae, IParvilux
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parvilux";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 717804;

    /// <inheritdoc />
    public virtual string GenusName => "Parvilux";

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
