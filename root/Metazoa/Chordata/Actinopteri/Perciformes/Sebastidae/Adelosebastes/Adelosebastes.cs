using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae.Adelosebastes;

/// <summary>
/// Abstract class for Adelosebastes (genus).
/// NCBI TaxId: 1311529
/// </summary>
public abstract class Adelosebastes : Sebastidae, IAdelosebastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Adelosebastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1311529;

    /// <inheritdoc />
    public virtual string GenusName => "Adelosebastes";

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
