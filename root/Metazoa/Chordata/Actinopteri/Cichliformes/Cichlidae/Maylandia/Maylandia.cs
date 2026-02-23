using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Maylandia;

/// <summary>
/// Abstract class for Maylandia (genus).
/// NCBI TaxId: 143623
/// </summary>
public abstract class Maylandia : Cichlidae, IMaylandia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Maylandia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143623;

    /// <inheritdoc />
    public virtual string GenusName => "Maylandia";

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
