using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Setarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Setarchidae.Setarches;

/// <summary>
/// Abstract class for Setarches (genus).
/// NCBI TaxId: 274713
/// </summary>
public abstract class Setarches : Setarchidae, ISetarches
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Setarches";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274713;

    /// <inheritdoc />
    public virtual string GenusName => "Setarches";

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
