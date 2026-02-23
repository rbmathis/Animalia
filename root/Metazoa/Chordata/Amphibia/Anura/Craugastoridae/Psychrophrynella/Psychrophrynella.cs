using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Psychrophrynella;

/// <summary>
/// Abstract class for Psychrophrynella (genus).
/// NCBI TaxId: 491218
/// </summary>
public abstract class Psychrophrynella : Craugastoridae, IPsychrophrynella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psychrophrynella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 491218;

    /// <inheritdoc />
    public virtual string GenusName => "Psychrophrynella";

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
