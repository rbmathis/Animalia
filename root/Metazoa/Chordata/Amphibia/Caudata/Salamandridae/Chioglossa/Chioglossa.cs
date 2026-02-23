using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Chioglossa;

/// <summary>
/// Abstract class for Chioglossa (genus).
/// NCBI TaxId: 156856
/// </summary>
public abstract class Chioglossa : Salamandridae, IChioglossa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chioglossa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 156856;

    /// <inheritdoc />
    public virtual string GenusName => "Chioglossa";

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
