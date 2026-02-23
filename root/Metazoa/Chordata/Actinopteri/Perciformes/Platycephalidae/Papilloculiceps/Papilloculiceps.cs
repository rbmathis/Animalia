using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Papilloculiceps;

/// <summary>
/// Abstract class for Papilloculiceps (genus).
/// NCBI TaxId: 990994
/// </summary>
public abstract class Papilloculiceps : Platycephalidae, IPapilloculiceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Papilloculiceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990994;

    /// <inheritdoc />
    public virtual string GenusName => "Papilloculiceps";

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
