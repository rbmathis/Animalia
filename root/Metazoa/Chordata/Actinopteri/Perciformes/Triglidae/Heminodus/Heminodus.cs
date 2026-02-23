using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae.Heminodus;

/// <summary>
/// Abstract class for Heminodus (genus).
/// NCBI TaxId: 3111722
/// </summary>
public abstract class Heminodus : Triglidae, IHeminodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heminodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3111722;

    /// <inheritdoc />
    public virtual string GenusName => "Heminodus";

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
