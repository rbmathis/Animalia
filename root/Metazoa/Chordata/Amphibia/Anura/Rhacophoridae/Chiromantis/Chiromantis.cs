using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Chiromantis;

/// <summary>
/// Abstract class for Chiromantis (genus).
/// NCBI TaxId: 39609
/// </summary>
public abstract class Chiromantis : Rhacophoridae, IChiromantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chiromantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39609;

    /// <inheritdoc />
    public virtual string GenusName => "Chiromantis";

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
