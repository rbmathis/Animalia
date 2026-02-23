using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Rhabdophis;

/// <summary>
/// Abstract class for Rhabdophis (genus).
/// NCBI TaxId: 46270
/// </summary>
public abstract class Rhabdophis : Colubridae, IRhabdophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhabdophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46270;

    /// <inheritdoc />
    public virtual string GenusName => "Rhabdophis";

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
