using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Ictinaetus;

/// <summary>
/// Abstract class for Ictinaetus (genus).
/// NCBI TaxId: 307639
/// </summary>
public abstract class Ictinaetus : Accipitridae, IIctinaetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ictinaetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 307639;

    /// <inheritdoc />
    public virtual string GenusName => "Ictinaetus";

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
