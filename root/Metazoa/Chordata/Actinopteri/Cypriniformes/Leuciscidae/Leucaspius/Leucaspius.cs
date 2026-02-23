using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Leucaspius;

/// <summary>
/// Abstract class for Leucaspius (genus).
/// NCBI TaxId: 58322
/// </summary>
public abstract class Leucaspius : Leuciscidae, ILeucaspius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leucaspius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58322;

    /// <inheritdoc />
    public virtual string GenusName => "Leucaspius";

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
