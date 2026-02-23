using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Cynopotamus;

/// <summary>
/// Abstract class for Cynopotamus (genus).
/// NCBI TaxId: 42574
/// </summary>
public abstract class Cynopotamus : Characidae, ICynopotamus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cynopotamus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42574;

    /// <inheritdoc />
    public virtual string GenusName => "Cynopotamus";

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
