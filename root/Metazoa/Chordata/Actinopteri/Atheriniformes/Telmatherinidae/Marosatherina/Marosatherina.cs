using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Telmatherinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Telmatherinidae.Marosatherina;

/// <summary>
/// Abstract class for Marosatherina (genus).
/// NCBI TaxId: 238704
/// </summary>
public abstract class Marosatherina : Telmatherinidae, IMarosatherina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Marosatherina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238704;

    /// <inheritdoc />
    public virtual string GenusName => "Marosatherina";

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
