using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cincelichthys;

/// <summary>
/// Abstract class for Cincelichthys (genus).
/// NCBI TaxId: 1830340
/// </summary>
public abstract class Cincelichthys : Cichlidae, ICincelichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cincelichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1830340;

    /// <inheritdoc />
    public virtual string GenusName => "Cincelichthys";

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
