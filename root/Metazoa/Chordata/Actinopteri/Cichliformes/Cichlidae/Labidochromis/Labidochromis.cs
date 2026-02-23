using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Labidochromis;

/// <summary>
/// Abstract class for Labidochromis (genus).
/// NCBI TaxId: 50896
/// </summary>
public abstract class Labidochromis : Cichlidae, ILabidochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Labidochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50896;

    /// <inheritdoc />
    public virtual string GenusName => "Labidochromis";

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
