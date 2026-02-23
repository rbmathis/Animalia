using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Occella;

/// <summary>
/// Abstract class for Occella (genus).
/// NCBI TaxId: 497284
/// </summary>
public abstract class Occella : Agonidae, IOccella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Occella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 497284;

    /// <inheritdoc />
    public virtual string GenusName => "Occella";

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
