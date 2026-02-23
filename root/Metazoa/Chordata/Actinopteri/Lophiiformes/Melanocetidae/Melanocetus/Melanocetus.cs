using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Melanocetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Melanocetidae.Melanocetus;

/// <summary>
/// Abstract class for Melanocetus (genus).
/// NCBI TaxId: 181424
/// </summary>
public abstract class Melanocetus : Melanocetidae, IMelanocetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanocetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181424;

    /// <inheritdoc />
    public virtual string GenusName => "Melanocetus";

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
