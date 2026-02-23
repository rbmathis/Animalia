using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Genyochromis;

/// <summary>
/// Abstract class for Genyochromis (genus).
/// NCBI TaxId: 57302
/// </summary>
public abstract class Genyochromis : Cichlidae, IGenyochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Genyochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57302;

    /// <inheritdoc />
    public virtual string GenusName => "Genyochromis";

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
