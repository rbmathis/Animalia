using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Setarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Setarchidae.Lioscorpius;

/// <summary>
/// Abstract class for Lioscorpius (genus).
/// NCBI TaxId: 2578389
/// </summary>
public abstract class Lioscorpius : Setarchidae, ILioscorpius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lioscorpius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2578389;

    /// <inheritdoc />
    public virtual string GenusName => "Lioscorpius";

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
