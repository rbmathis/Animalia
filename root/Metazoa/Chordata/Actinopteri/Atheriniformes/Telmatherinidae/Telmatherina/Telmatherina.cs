using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Telmatherinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Telmatherinidae.Telmatherina;

/// <summary>
/// Abstract class for Telmatherina (genus).
/// NCBI TaxId: 270533
/// </summary>
public abstract class Telmatherina : Telmatherinidae, ITelmatherina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Telmatherina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270533;

    /// <inheritdoc />
    public virtual string GenusName => "Telmatherina";

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
