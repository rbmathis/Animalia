using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Dolichophis;

/// <summary>
/// Abstract class for Dolichophis (genus).
/// NCBI TaxId: 927615
/// </summary>
public abstract class Dolichophis : Colubridae, IDolichophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dolichophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 927615;

    /// <inheritdoc />
    public virtual string GenusName => "Dolichophis";

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
