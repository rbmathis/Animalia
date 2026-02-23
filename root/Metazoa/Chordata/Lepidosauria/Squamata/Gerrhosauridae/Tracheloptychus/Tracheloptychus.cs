using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae.Tracheloptychus;

/// <summary>
/// Abstract class for Tracheloptychus (genus).
/// NCBI TaxId: 174272
/// </summary>
public abstract class Tracheloptychus : Gerrhosauridae, ITracheloptychus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tracheloptychus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174272;

    /// <inheritdoc />
    public virtual string GenusName => "Tracheloptychus";

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
