using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Telmatochromis;

/// <summary>
/// Abstract class for Telmatochromis (genus).
/// NCBI TaxId: 32510
/// </summary>
public abstract class Telmatochromis : Cichlidae, ITelmatochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Telmatochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32510;

    /// <inheritdoc />
    public virtual string GenusName => "Telmatochromis";

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
