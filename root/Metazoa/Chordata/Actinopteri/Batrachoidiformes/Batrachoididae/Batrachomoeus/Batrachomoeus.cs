using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Batrachomoeus;

/// <summary>
/// Abstract class for Batrachomoeus (genus).
/// NCBI TaxId: 262769
/// </summary>
public abstract class Batrachomoeus : Batrachoididae, IBatrachomoeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Batrachomoeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 262769;

    /// <inheritdoc />
    public virtual string GenusName => "Batrachomoeus";

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
