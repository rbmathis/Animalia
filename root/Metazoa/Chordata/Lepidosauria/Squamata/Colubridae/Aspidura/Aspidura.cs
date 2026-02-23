using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Aspidura;

/// <summary>
/// Abstract class for Aspidura (genus).
/// NCBI TaxId: 1296313
/// </summary>
public abstract class Aspidura : Colubridae, IAspidura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aspidura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1296313;

    /// <inheritdoc />
    public virtual string GenusName => "Aspidura";

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
