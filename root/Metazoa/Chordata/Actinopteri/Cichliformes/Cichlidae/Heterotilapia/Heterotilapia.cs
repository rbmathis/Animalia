using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Heterotilapia;

/// <summary>
/// Abstract class for Heterotilapia (genus).
/// NCBI TaxId: 1315714
/// </summary>
public abstract class Heterotilapia : Cichlidae, IHeterotilapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heterotilapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1315714;

    /// <inheritdoc />
    public virtual string GenusName => "Heterotilapia";

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
