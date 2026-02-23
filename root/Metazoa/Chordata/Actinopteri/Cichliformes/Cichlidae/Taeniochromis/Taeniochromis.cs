using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Taeniochromis;

/// <summary>
/// Abstract class for Taeniochromis (genus).
/// NCBI TaxId: 323813
/// </summary>
public abstract class Taeniochromis : Cichlidae, ITaeniochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taeniochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 323813;

    /// <inheritdoc />
    public virtual string GenusName => "Taeniochromis";

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
