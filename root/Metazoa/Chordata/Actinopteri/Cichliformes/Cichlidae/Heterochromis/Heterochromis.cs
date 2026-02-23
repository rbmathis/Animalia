using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Heterochromis;

/// <summary>
/// Abstract class for Heterochromis (genus).
/// NCBI TaxId: 73562
/// </summary>
public abstract class Heterochromis : Cichlidae, IHeterochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heterochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 73562;

    /// <inheritdoc />
    public virtual string GenusName => "Heterochromis";

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
