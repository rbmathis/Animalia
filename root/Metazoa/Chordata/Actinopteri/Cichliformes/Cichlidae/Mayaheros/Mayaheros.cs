using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Mayaheros;

/// <summary>
/// Abstract class for Mayaheros (genus).
/// NCBI TaxId: 318742
/// </summary>
public abstract class Mayaheros : Cichlidae, IMayaheros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mayaheros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 318742;

    /// <inheritdoc />
    public virtual string GenusName => "Mayaheros";

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
