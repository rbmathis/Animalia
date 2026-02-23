using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Platyceps;

/// <summary>
/// Abstract class for Platyceps (genus).
/// NCBI TaxId: 166092
/// </summary>
public abstract class Platyceps : Colubridae, IPlatyceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platyceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166092;

    /// <inheritdoc />
    public virtual string GenusName => "Platyceps";

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
