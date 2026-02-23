using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Sacura;

/// <summary>
/// Abstract class for Sacura (genus).
/// NCBI TaxId: 1401208
/// </summary>
public abstract class Sacura : Anthiadidae, ISacura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sacura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1401208;

    /// <inheritdoc />
    public virtual string GenusName => "Sacura";

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
