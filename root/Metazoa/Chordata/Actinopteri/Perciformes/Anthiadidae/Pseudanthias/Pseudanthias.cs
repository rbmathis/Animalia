using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Pseudanthias;

/// <summary>
/// Abstract class for Pseudanthias (genus).
/// NCBI TaxId: 270577
/// </summary>
public abstract class Pseudanthias : Anthiadidae, IPseudanthias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudanthias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270577;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudanthias";

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
