using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Nanochromis;

/// <summary>
/// Abstract class for Nanochromis (genus).
/// NCBI TaxId: 219372
/// </summary>
public abstract class Nanochromis : Cichlidae, INanochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nanochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 219372;

    /// <inheritdoc />
    public virtual string GenusName => "Nanochromis";

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
