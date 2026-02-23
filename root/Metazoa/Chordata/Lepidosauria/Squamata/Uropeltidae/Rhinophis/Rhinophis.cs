using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae.Rhinophis;

/// <summary>
/// Abstract class for Rhinophis (genus).
/// NCBI TaxId: 39233
/// </summary>
public abstract class Rhinophis : Uropeltidae, IRhinophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39233;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinophis";

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
