using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Saxatilia;

/// <summary>
/// Abstract class for Saxatilia (genus).
/// NCBI TaxId: 3363484
/// </summary>
public abstract class Saxatilia : Cichlidae, ISaxatilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saxatilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363484;

    /// <inheritdoc />
    public virtual string GenusName => "Saxatilia";

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
