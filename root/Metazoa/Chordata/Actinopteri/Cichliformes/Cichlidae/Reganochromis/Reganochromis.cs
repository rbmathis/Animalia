using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Reganochromis;

/// <summary>
/// Abstract class for Reganochromis (genus).
/// NCBI TaxId: 70787
/// </summary>
public abstract class Reganochromis : Cichlidae, IReganochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Reganochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70787;

    /// <inheritdoc />
    public virtual string GenusName => "Reganochromis";

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
