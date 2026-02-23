using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Percis;

/// <summary>
/// Abstract class for Percis (genus).
/// NCBI TaxId: 1573629
/// </summary>
public abstract class Percis : Agonidae, IPercis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Percis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1573629;

    /// <inheritdoc />
    public virtual string GenusName => "Percis";

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
