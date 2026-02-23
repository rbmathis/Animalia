using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cynotilapia;

/// <summary>
/// Abstract class for Cynotilapia (genus).
/// NCBI TaxId: 205485
/// </summary>
public abstract class Cynotilapia : Cichlidae, ICynotilapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cynotilapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 205485;

    /// <inheritdoc />
    public virtual string GenusName => "Cynotilapia";

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
