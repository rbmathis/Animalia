using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Haplochromis;

/// <summary>
/// Abstract class for Haplochromis (genus).
/// NCBI TaxId: 8121
/// </summary>
public abstract class Haplochromis : Cichlidae, IHaplochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haplochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8121;

    /// <inheritdoc />
    public virtual string GenusName => "Haplochromis";

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
