using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Orientocoluber;

/// <summary>
/// Abstract class for Orientocoluber (genus).
/// NCBI TaxId: 2212974
/// </summary>
public abstract class Orientocoluber : Colubridae, IOrientocoluber
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orientocoluber";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2212974;

    /// <inheritdoc />
    public virtual string GenusName => "Orientocoluber";

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
