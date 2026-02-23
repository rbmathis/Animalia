using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Helophis;

/// <summary>
/// Abstract class for Helophis (genus).
/// NCBI TaxId: 1544985
/// </summary>
public abstract class Helophis : Colubridae, IHelophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Helophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544985;

    /// <inheritdoc />
    public virtual string GenusName => "Helophis";

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
