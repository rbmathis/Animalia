using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Limnochromis;

/// <summary>
/// Abstract class for Limnochromis (genus).
/// NCBI TaxId: 27748
/// </summary>
public abstract class Limnochromis : Cichlidae, ILimnochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Limnochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27748;

    /// <inheritdoc />
    public virtual string GenusName => "Limnochromis";

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
