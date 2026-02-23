using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Ceuthomantis;

/// <summary>
/// Abstract class for Ceuthomantis (genus).
/// NCBI TaxId: 696018
/// </summary>
public abstract class Ceuthomantis : Craugastoridae, ICeuthomantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ceuthomantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 696018;

    /// <inheritdoc />
    public virtual string GenusName => "Ceuthomantis";

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
