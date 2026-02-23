using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Hyaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Hyaenidae.Hyaena;

/// <summary>
/// Abstract class for Hyaena (genus).
/// NCBI TaxId: 95911
/// </summary>
public abstract class Hyaena : Hyaenidae, IHyaena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyaena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 95911;

    /// <inheritdoc />
    public virtual string GenusName => "Hyaena";

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
