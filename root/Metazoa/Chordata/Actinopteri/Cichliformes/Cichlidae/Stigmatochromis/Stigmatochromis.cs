using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Stigmatochromis;

/// <summary>
/// Abstract class for Stigmatochromis (genus).
/// NCBI TaxId: 120228
/// </summary>
public abstract class Stigmatochromis : Cichlidae, IStigmatochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stigmatochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 120228;

    /// <inheritdoc />
    public virtual string GenusName => "Stigmatochromis";

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
