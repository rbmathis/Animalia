using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Sarritor;

/// <summary>
/// Abstract class for Sarritor (genus).
/// NCBI TaxId: 274776
/// </summary>
public abstract class Sarritor : Agonidae, ISarritor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sarritor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274776;

    /// <inheritdoc />
    public virtual string GenusName => "Sarritor";

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
