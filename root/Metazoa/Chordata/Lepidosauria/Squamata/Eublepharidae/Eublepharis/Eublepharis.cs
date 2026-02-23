using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Eublepharidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Eublepharidae.Eublepharis;

/// <summary>
/// Abstract class for Eublepharis (genus).
/// NCBI TaxId: 96736
/// </summary>
public abstract class Eublepharis : Eublepharidae, IEublepharis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eublepharis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 96736;

    /// <inheritdoc />
    public virtual string GenusName => "Eublepharis";

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
