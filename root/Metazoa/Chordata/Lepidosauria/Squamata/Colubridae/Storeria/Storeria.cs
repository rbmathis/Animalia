using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Storeria;

/// <summary>
/// Abstract class for Storeria (genus).
/// NCBI TaxId: 46281
/// </summary>
public abstract class Storeria : Colubridae, IStoreria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Storeria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46281;

    /// <inheritdoc />
    public virtual string GenusName => "Storeria";

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
