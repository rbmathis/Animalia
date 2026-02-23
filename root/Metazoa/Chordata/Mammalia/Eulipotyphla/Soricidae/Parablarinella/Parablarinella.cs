using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Parablarinella;

/// <summary>
/// Abstract class for Parablarinella (genus).
/// NCBI TaxId: 2981328
/// </summary>
public abstract class Parablarinella : Soricidae, IParablarinella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parablarinella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2981328;

    /// <inheritdoc />
    public virtual string GenusName => "Parablarinella";

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
