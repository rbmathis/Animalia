using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Luciobrotula;

/// <summary>
/// Abstract class for Luciobrotula (genus).
/// NCBI TaxId: 1843795
/// </summary>
public abstract class Luciobrotula : Ophidiidae, ILuciobrotula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Luciobrotula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1843795;

    /// <inheritdoc />
    public virtual string GenusName => "Luciobrotula";

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
