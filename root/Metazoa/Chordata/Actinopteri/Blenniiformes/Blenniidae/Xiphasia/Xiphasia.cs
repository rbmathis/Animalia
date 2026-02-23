using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Xiphasia;

/// <summary>
/// Abstract class for Xiphasia (genus).
/// NCBI TaxId: 879905
/// </summary>
public abstract class Xiphasia : Blenniidae, IXiphasia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xiphasia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 879905;

    /// <inheritdoc />
    public virtual string GenusName => "Xiphasia";

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
