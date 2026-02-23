using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemisotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemisotidae.Hemisus;

/// <summary>
/// Abstract class for Hemisus (genus).
/// NCBI TaxId: 83970
/// </summary>
public abstract class Hemisus : Hemisotidae, IHemisus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemisus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 83970;

    /// <inheritdoc />
    public virtual string GenusName => "Hemisus";

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
