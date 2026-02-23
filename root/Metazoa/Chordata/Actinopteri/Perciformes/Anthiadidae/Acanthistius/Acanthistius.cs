using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Acanthistius;

/// <summary>
/// Abstract class for Acanthistius (genus).
/// NCBI TaxId: 327815
/// </summary>
public abstract class Acanthistius : Anthiadidae, IAcanthistius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthistius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 327815;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthistius";

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
