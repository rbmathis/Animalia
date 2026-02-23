using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Exocoetus;

/// <summary>
/// Abstract class for Exocoetus (genus).
/// NCBI TaxId: 143331
/// </summary>
public abstract class Exocoetus : Exocoetidae, IExocoetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Exocoetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143331;

    /// <inheritdoc />
    public virtual string GenusName => "Exocoetus";

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
