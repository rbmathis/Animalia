using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhinodermatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhinodermatidae.Rhinoderma;

/// <summary>
/// Abstract class for Rhinoderma (genus).
/// NCBI TaxId: 43562
/// </summary>
public abstract class Rhinoderma : Rhinodermatidae, IRhinoderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinoderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43562;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinoderma";

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
