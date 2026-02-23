using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Hypophthalmus;

/// <summary>
/// Abstract class for Hypophthalmus (genus).
/// NCBI TaxId: 238552
/// </summary>
public abstract class Hypophthalmus : Pimelodidae, IHypophthalmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypophthalmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238552;

    /// <inheritdoc />
    public virtual string GenusName => "Hypophthalmus";

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
