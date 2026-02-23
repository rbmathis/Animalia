using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Selenanthias;

/// <summary>
/// Abstract class for Selenanthias (genus).
/// NCBI TaxId: 1522438
/// </summary>
public abstract class Selenanthias : Anthiadidae, ISelenanthias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Selenanthias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1522438;

    /// <inheritdoc />
    public virtual string GenusName => "Selenanthias";

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
