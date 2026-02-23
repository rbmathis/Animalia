using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Drymomantis;

/// <summary>
/// Abstract class for Drymomantis (genus).
/// NCBI TaxId: 3680989
/// </summary>
public abstract class Drymomantis : Pelodryadidae, IDrymomantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Drymomantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3680989;

    /// <inheritdoc />
    public virtual string GenusName => "Drymomantis";

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
