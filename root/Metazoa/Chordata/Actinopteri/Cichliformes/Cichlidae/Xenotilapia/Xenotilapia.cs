using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Xenotilapia;

/// <summary>
/// Abstract class for Xenotilapia (genus).
/// NCBI TaxId: 27764
/// </summary>
public abstract class Xenotilapia : Cichlidae, IXenotilapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenotilapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27764;

    /// <inheritdoc />
    public virtual string GenusName => "Xenotilapia";

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
