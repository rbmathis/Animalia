using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Adelophis;

/// <summary>
/// Abstract class for Adelophis (genus).
/// NCBI TaxId: 173356
/// </summary>
public abstract class Adelophis : Colubridae, IAdelophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Adelophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 173356;

    /// <inheritdoc />
    public virtual string GenusName => "Adelophis";

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
