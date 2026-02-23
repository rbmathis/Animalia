using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Lithochromis;

/// <summary>
/// Abstract class for Lithochromis (genus).
/// NCBI TaxId: 303560
/// </summary>
public abstract class Lithochromis : Cichlidae, ILithochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lithochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303560;

    /// <inheritdoc />
    public virtual string GenusName => "Lithochromis";

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
