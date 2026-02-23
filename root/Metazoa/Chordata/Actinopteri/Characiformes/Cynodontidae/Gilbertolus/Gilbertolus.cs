using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Cynodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Cynodontidae.Gilbertolus;

/// <summary>
/// Abstract class for Gilbertolus (genus).
/// NCBI TaxId: 930321
/// </summary>
public abstract class Gilbertolus : Cynodontidae, IGilbertolus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gilbertolus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930321;

    /// <inheritdoc />
    public virtual string GenusName => "Gilbertolus";

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
