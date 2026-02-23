using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Muraenoclinus;

/// <summary>
/// Abstract class for Muraenoclinus (genus).
/// NCBI TaxId: 879876
/// </summary>
public abstract class Muraenoclinus : Clinidae, IMuraenoclinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Muraenoclinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 879876;

    /// <inheritdoc />
    public virtual string GenusName => "Muraenoclinus";

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
