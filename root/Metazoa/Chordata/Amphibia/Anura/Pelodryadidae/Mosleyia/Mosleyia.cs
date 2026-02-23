using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Mosleyia;

/// <summary>
/// Abstract class for Mosleyia (genus).
/// NCBI TaxId: 3681014
/// </summary>
public abstract class Mosleyia : Pelodryadidae, IMosleyia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mosleyia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3681014;

    /// <inheritdoc />
    public virtual string GenusName => "Mosleyia";

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
