using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhinodermatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhinodermatidae.Insuetophrynus;

/// <summary>
/// Abstract class for Insuetophrynus (genus).
/// NCBI TaxId: 247653
/// </summary>
public abstract class Insuetophrynus : Rhinodermatidae, IInsuetophrynus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Insuetophrynus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 247653;

    /// <inheritdoc />
    public virtual string GenusName => "Insuetophrynus";

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
