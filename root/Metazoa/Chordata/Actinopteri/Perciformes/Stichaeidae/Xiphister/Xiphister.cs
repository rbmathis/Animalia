using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Xiphister;

/// <summary>
/// Abstract class for Xiphister (genus).
/// NCBI TaxId: 283023
/// </summary>
public abstract class Xiphister : Stichaeidae, IXiphister
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xiphister";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 283023;

    /// <inheritdoc />
    public virtual string GenusName => "Xiphister";

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
