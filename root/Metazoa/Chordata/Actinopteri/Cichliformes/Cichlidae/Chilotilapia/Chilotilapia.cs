using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chilotilapia;

/// <summary>
/// Abstract class for Chilotilapia (genus).
/// NCBI TaxId: 323763
/// </summary>
public abstract class Chilotilapia : Cichlidae, IChilotilapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chilotilapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 323763;

    /// <inheritdoc />
    public virtual string GenusName => "Chilotilapia";

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
