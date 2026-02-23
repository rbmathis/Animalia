using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Liopeltis;

/// <summary>
/// Abstract class for Liopeltis (genus).
/// NCBI TaxId: 942189
/// </summary>
public abstract class Liopeltis : Colubridae, ILiopeltis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liopeltis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 942189;

    /// <inheritdoc />
    public virtual string GenusName => "Liopeltis";

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
