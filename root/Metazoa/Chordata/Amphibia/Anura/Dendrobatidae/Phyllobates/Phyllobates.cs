using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Phyllobates;

/// <summary>
/// Abstract class for Phyllobates (genus).
/// NCBI TaxId: 51961
/// </summary>
public abstract class Phyllobates : Dendrobatidae, IPhyllobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyllobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51961;

    /// <inheritdoc />
    public virtual string GenusName => "Phyllobates";

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
