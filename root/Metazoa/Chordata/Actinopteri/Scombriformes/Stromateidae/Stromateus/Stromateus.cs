using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Stromateidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Stromateidae.Stromateus;

/// <summary>
/// Abstract class for Stromateus (genus).
/// NCBI TaxId: 94244
/// </summary>
public abstract class Stromateus : Stromateidae, IStromateus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stromateus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94244;

    /// <inheritdoc />
    public virtual string GenusName => "Stromateus";

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
