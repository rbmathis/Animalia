using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pterochromis;

/// <summary>
/// Abstract class for Pterochromis (genus).
/// NCBI TaxId: 665439
/// </summary>
public abstract class Pterochromis : Cichlidae, IPterochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 665439;

    /// <inheritdoc />
    public virtual string GenusName => "Pterochromis";

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
