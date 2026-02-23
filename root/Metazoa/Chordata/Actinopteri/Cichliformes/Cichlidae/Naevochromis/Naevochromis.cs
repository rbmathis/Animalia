using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Naevochromis;

/// <summary>
/// Abstract class for Naevochromis (genus).
/// NCBI TaxId: 2305429
/// </summary>
public abstract class Naevochromis : Cichlidae, INaevochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Naevochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2305429;

    /// <inheritdoc />
    public virtual string GenusName => "Naevochromis";

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
