using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lepidarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lepidarchidae.Lepidarchus;

/// <summary>
/// Abstract class for Lepidarchus (genus).
/// NCBI TaxId: 1042455
/// </summary>
public abstract class Lepidarchus : Lepidarchidae, ILepidarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1042455;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidarchus";

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
