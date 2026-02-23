using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Notoscopelus;

/// <summary>
/// Abstract class for Notoscopelus (genus).
/// NCBI TaxId: 123256
/// </summary>
public abstract class Notoscopelus : Myctophidae, INotoscopelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notoscopelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123256;

    /// <inheritdoc />
    public virtual string GenusName => "Notoscopelus";

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
