using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Kumococius;

/// <summary>
/// Abstract class for Kumococius (genus).
/// NCBI TaxId: 435226
/// </summary>
public abstract class Kumococius : Platycephalidae, IKumococius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kumococius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 435226;

    /// <inheritdoc />
    public virtual string GenusName => "Kumococius";

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
