using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Jordaniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Jordaniidae.Jordania;

/// <summary>
/// Abstract class for Jordania (genus).
/// NCBI TaxId: 274763
/// </summary>
public abstract class Jordania : Jordaniidae, IJordania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Jordania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274763;

    /// <inheritdoc />
    public virtual string GenusName => "Jordania";

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
