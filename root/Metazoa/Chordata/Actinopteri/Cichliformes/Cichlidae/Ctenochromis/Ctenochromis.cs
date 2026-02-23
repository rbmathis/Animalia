using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Ctenochromis;

/// <summary>
/// Abstract class for Ctenochromis (genus).
/// NCBI TaxId: 64552
/// </summary>
public abstract class Ctenochromis : Cichlidae, ICtenochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ctenochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 64552;

    /// <inheritdoc />
    public virtual string GenusName => "Ctenochromis";

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
