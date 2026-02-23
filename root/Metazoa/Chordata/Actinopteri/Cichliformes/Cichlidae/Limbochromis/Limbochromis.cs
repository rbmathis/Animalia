using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Limbochromis;

/// <summary>
/// Abstract class for Limbochromis (genus).
/// NCBI TaxId: 691892
/// </summary>
public abstract class Limbochromis : Cichlidae, ILimbochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Limbochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 691892;

    /// <inheritdoc />
    public virtual string GenusName => "Limbochromis";

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
