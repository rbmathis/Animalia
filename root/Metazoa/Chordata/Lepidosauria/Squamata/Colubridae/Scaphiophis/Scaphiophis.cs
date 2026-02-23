using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Scaphiophis;

/// <summary>
/// Abstract class for Scaphiophis (genus).
/// NCBI TaxId: 382773
/// </summary>
public abstract class Scaphiophis : Colubridae, IScaphiophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scaphiophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 382773;

    /// <inheritdoc />
    public virtual string GenusName => "Scaphiophis";

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
