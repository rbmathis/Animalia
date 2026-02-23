using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Heterocharax;

/// <summary>
/// Abstract class for Heterocharax (genus).
/// NCBI TaxId: 930327
/// </summary>
public abstract class Heterocharax : Characidae, IHeterocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heterocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930327;

    /// <inheritdoc />
    public virtual string GenusName => "Heterocharax";

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
