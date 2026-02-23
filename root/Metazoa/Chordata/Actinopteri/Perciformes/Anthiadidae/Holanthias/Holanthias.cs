using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Holanthias;

/// <summary>
/// Abstract class for Holanthias (genus).
/// NCBI TaxId: 206134
/// </summary>
public abstract class Holanthias : Anthiadidae, IHolanthias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Holanthias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206134;

    /// <inheritdoc />
    public virtual string GenusName => "Holanthias";

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
