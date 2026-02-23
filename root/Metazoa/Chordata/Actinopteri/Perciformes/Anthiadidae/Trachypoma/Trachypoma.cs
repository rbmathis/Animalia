using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Trachypoma;

/// <summary>
/// Abstract class for Trachypoma (genus).
/// NCBI TaxId: 1867232
/// </summary>
public abstract class Trachypoma : Anthiadidae, ITrachypoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachypoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1867232;

    /// <inheritdoc />
    public virtual string GenusName => "Trachypoma";

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
