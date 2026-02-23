using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Sordellina;

/// <summary>
/// Abstract class for Sordellina (genus).
/// NCBI TaxId: 1260374
/// </summary>
public abstract class Sordellina : Dipsadidae, ISordellina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sordellina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1260374;

    /// <inheritdoc />
    public virtual string GenusName => "Sordellina";

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
