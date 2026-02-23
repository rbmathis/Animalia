using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae.Steindachnerina;

/// <summary>
/// Abstract class for Steindachnerina (genus).
/// NCBI TaxId: 42615
/// </summary>
public abstract class Steindachnerina : Curimatidae, ISteindachnerina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Steindachnerina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42615;

    /// <inheritdoc />
    public virtual string GenusName => "Steindachnerina";

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
