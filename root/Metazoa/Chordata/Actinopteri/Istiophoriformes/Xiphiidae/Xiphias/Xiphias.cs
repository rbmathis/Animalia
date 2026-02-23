using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Xiphiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Xiphiidae.Xiphias;

/// <summary>
/// Abstract class for Xiphias (genus).
/// NCBI TaxId: 8244
/// </summary>
public abstract class Xiphias : Xiphiidae, IXiphias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xiphias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8244;

    /// <inheritdoc />
    public virtual string GenusName => "Xiphias";

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
