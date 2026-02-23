using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Microkayla;

/// <summary>
/// Abstract class for Microkayla (genus).
/// NCBI TaxId: 2116695
/// </summary>
public abstract class Microkayla : Craugastoridae, IMicrokayla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microkayla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2116695;

    /// <inheritdoc />
    public virtual string GenusName => "Microkayla";

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
