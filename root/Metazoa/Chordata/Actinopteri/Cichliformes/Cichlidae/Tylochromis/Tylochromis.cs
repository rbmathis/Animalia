using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tylochromis;

/// <summary>
/// Abstract class for Tylochromis (genus).
/// NCBI TaxId: 32512
/// </summary>
public abstract class Tylochromis : Cichlidae, ITylochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tylochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32512;

    /// <inheritdoc />
    public virtual string GenusName => "Tylochromis";

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
