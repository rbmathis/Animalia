using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Neochromis;

/// <summary>
/// Abstract class for Neochromis (genus).
/// NCBI TaxId: 51177
/// </summary>
public abstract class Neochromis : Cichlidae, INeochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51177;

    /// <inheritdoc />
    public virtual string GenusName => "Neochromis";

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
