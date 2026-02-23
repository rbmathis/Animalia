using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Dendrelaphis;

/// <summary>
/// Abstract class for Dendrelaphis (genus).
/// NCBI TaxId: 46296
/// </summary>
public abstract class Dendrelaphis : Colubridae, IDendrelaphis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendrelaphis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46296;

    /// <inheritdoc />
    public virtual string GenusName => "Dendrelaphis";

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
