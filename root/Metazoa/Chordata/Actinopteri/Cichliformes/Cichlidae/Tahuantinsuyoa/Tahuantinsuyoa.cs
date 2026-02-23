using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tahuantinsuyoa;

/// <summary>
/// Abstract class for Tahuantinsuyoa (genus).
/// NCBI TaxId: 449286
/// </summary>
public abstract class Tahuantinsuyoa : Cichlidae, ITahuantinsuyoa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tahuantinsuyoa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 449286;

    /// <inheritdoc />
    public virtual string GenusName => "Tahuantinsuyoa";

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
