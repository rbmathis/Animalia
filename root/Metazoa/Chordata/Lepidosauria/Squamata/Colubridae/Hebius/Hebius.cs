using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Hebius;

/// <summary>
/// Abstract class for Hebius (genus).
/// NCBI TaxId: 1591003
/// </summary>
public abstract class Hebius : Colubridae, IHebius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hebius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1591003;

    /// <inheritdoc />
    public virtual string GenusName => "Hebius";

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
