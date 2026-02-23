using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Gaurochromis;

/// <summary>
/// Abstract class for Gaurochromis (genus).
/// NCBI TaxId: 1202906
/// </summary>
public abstract class Gaurochromis : Cichlidae, IGaurochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gaurochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1202906;

    /// <inheritdoc />
    public virtual string GenusName => "Gaurochromis";

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
