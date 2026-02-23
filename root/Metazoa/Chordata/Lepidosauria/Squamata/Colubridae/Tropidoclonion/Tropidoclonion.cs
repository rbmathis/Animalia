using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Tropidoclonion;

/// <summary>
/// Abstract class for Tropidoclonion (genus).
/// NCBI TaxId: 173534
/// </summary>
public abstract class Tropidoclonion : Colubridae, ITropidoclonion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tropidoclonion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 173534;

    /// <inheritdoc />
    public virtual string GenusName => "Tropidoclonion";

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
