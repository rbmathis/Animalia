using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Amphilophus;

/// <summary>
/// Abstract class for Amphilophus (genus).
/// NCBI TaxId: 61818
/// </summary>
public abstract class Amphilophus : Cichlidae, IAmphilophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amphilophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61818;

    /// <inheritdoc />
    public virtual string GenusName => "Amphilophus";

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
