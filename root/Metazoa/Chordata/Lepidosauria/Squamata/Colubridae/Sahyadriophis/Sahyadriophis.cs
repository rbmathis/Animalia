using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Sahyadriophis;

/// <summary>
/// Abstract class for Sahyadriophis (genus).
/// NCBI TaxId: 3076720
/// </summary>
public abstract class Sahyadriophis : Colubridae, ISahyadriophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sahyadriophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3076720;

    /// <inheritdoc />
    public virtual string GenusName => "Sahyadriophis";

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
