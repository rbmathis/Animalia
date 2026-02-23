using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Scaphiodontophis;

/// <summary>
/// Abstract class for Scaphiodontophis (genus).
/// NCBI TaxId: 703967
/// </summary>
public abstract class Scaphiodontophis : Colubridae, IScaphiodontophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scaphiodontophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 703967;

    /// <inheritdoc />
    public virtual string GenusName => "Scaphiodontophis";

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
