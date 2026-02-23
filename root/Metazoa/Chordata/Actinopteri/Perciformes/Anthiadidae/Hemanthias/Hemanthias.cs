using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Hemanthias;

/// <summary>
/// Abstract class for Hemanthias (genus).
/// NCBI TaxId: 274790
/// </summary>
public abstract class Hemanthias : Anthiadidae, IHemanthias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemanthias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274790;

    /// <inheritdoc />
    public virtual string GenusName => "Hemanthias";

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
