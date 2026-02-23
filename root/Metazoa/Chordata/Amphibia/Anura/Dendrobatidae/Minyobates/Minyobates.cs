using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Minyobates;

/// <summary>
/// Abstract class for Minyobates (genus).
/// NCBI TaxId: 1004434
/// </summary>
public abstract class Minyobates : Dendrobatidae, IMinyobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Minyobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1004434;

    /// <inheritdoc />
    public virtual string GenusName => "Minyobates";

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
