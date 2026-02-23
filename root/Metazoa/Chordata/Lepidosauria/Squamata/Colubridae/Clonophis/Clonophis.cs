using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Clonophis;

/// <summary>
/// Abstract class for Clonophis (genus).
/// NCBI TaxId: 183599
/// </summary>
public abstract class Clonophis : Colubridae, IClonophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clonophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183599;

    /// <inheritdoc />
    public virtual string GenusName => "Clonophis";

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
