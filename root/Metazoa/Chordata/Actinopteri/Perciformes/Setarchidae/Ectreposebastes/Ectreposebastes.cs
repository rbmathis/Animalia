using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Setarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Setarchidae.Ectreposebastes;

/// <summary>
/// Abstract class for Ectreposebastes (genus).
/// NCBI TaxId: 1609600
/// </summary>
public abstract class Ectreposebastes : Setarchidae, IEctreposebastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ectreposebastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1609600;

    /// <inheritdoc />
    public virtual string GenusName => "Ectreposebastes";

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
