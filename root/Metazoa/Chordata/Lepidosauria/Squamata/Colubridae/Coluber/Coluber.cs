using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Coluber;

/// <summary>
/// Abstract class for Coluber (genus).
/// NCBI TaxId: 8589
/// </summary>
public abstract class Coluber : Colubridae, IColuber
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coluber";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8589;

    /// <inheritdoc />
    public virtual string GenusName => "Coluber";

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
