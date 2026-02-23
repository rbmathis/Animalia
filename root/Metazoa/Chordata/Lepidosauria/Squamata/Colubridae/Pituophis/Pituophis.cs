using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Pituophis;

/// <summary>
/// Abstract class for Pituophis (genus).
/// NCBI TaxId: 8594
/// </summary>
public abstract class Pituophis : Colubridae, IPituophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pituophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8594;

    /// <inheritdoc />
    public virtual string GenusName => "Pituophis";

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
