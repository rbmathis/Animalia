using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Ophisops;

/// <summary>
/// Abstract class for Ophisops (genus).
/// NCBI TaxId: 90064
/// </summary>
public abstract class Ophisops : Lacertidae, IOphisops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophisops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 90064;

    /// <inheritdoc />
    public virtual string GenusName => "Ophisops";

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
