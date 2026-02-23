using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Dryophiops;

/// <summary>
/// Abstract class for Dryophiops (genus).
/// NCBI TaxId: 1544571
/// </summary>
public abstract class Dryophiops : Colubridae, IDryophiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dryophiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544571;

    /// <inheritdoc />
    public virtual string GenusName => "Dryophiops";

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
