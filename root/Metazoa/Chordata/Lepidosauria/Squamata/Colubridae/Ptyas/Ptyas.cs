using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Ptyas;

/// <summary>
/// Abstract class for Ptyas (genus).
/// NCBI TaxId: 31141
/// </summary>
public abstract class Ptyas : Colubridae, IPtyas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptyas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 31141;

    /// <inheritdoc />
    public virtual string GenusName => "Ptyas";

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
