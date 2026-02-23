using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Trematochromis;

/// <summary>
/// Abstract class for Trematochromis (genus).
/// NCBI TaxId: 1171438
/// </summary>
public abstract class Trematochromis : Cichlidae, ITrematochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trematochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1171438;

    /// <inheritdoc />
    public virtual string GenusName => "Trematochromis";

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
