using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Rubricatochromis;

/// <summary>
/// Abstract class for Rubricatochromis (genus).
/// NCBI TaxId: 3025441
/// </summary>
public abstract class Rubricatochromis : Cichlidae, IRubricatochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rubricatochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3025441;

    /// <inheritdoc />
    public virtual string GenusName => "Rubricatochromis";

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
