using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.Ilyophis;

/// <summary>
/// Abstract class for Ilyophis (genus).
/// NCBI TaxId: 391181
/// </summary>
public abstract class Ilyophis : Synaphobranchidae, IIlyophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ilyophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 391181;

    /// <inheritdoc />
    public virtual string GenusName => "Ilyophis";

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
