using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Charax;

/// <summary>
/// Abstract class for Charax (genus).
/// NCBI TaxId: 642576
/// </summary>
public abstract class Charax : Characidae, ICharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Charax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 642576;

    /// <inheritdoc />
    public virtual string GenusName => "Charax";

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
