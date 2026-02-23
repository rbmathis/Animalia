using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Dendrobates;

/// <summary>
/// Abstract class for Dendrobates (genus).
/// NCBI TaxId: 43470
/// </summary>
public abstract class Dendrobates : Dendrobatidae, IDendrobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendrobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43470;

    /// <inheritdoc />
    public virtual string GenusName => "Dendrobates";

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
