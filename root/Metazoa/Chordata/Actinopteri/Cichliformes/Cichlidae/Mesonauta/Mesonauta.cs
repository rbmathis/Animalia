using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Mesonauta;

/// <summary>
/// Abstract class for Mesonauta (genus).
/// NCBI TaxId: 74126
/// </summary>
public abstract class Mesonauta : Cichlidae, IMesonauta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesonauta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74126;

    /// <inheritdoc />
    public virtual string GenusName => "Mesonauta";

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
