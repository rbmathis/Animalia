using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Hydraethiops;

/// <summary>
/// Abstract class for Hydraethiops (genus).
/// NCBI TaxId: 1544993
/// </summary>
public abstract class Hydraethiops : Colubridae, IHydraethiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydraethiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544993;

    /// <inheritdoc />
    public virtual string GenusName => "Hydraethiops";

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
