using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Leptophis;

/// <summary>
/// Abstract class for Leptophis (genus).
/// NCBI TaxId: 703965
/// </summary>
public abstract class Leptophis : Colubridae, ILeptophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 703965;

    /// <inheritdoc />
    public virtual string GenusName => "Leptophis";

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
