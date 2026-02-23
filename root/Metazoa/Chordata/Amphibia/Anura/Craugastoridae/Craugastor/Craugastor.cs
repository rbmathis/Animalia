using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Craugastor;

/// <summary>
/// Abstract class for Craugastor (genus).
/// NCBI TaxId: 228649
/// </summary>
public abstract class Craugastor : Craugastoridae, ICraugastor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Craugastor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 228649;

    /// <inheritdoc />
    public virtual string GenusName => "Craugastor";

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
