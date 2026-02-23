using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Parabrotulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Parabrotulidae.Parabrotula;

/// <summary>
/// Abstract class for Parabrotula (genus).
/// NCBI TaxId: 1522434
/// </summary>
public abstract class Parabrotula : Parabrotulidae, IParabrotula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parabrotula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1522434;

    /// <inheritdoc />
    public virtual string GenusName => "Parabrotula";

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
