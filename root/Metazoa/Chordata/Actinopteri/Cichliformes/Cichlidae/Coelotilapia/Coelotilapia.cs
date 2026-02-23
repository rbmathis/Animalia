using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Coelotilapia;

/// <summary>
/// Abstract class for Coelotilapia (genus).
/// NCBI TaxId: 1315709
/// </summary>
public abstract class Coelotilapia : Cichlidae, ICoelotilapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coelotilapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1315709;

    /// <inheritdoc />
    public virtual string GenusName => "Coelotilapia";

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
