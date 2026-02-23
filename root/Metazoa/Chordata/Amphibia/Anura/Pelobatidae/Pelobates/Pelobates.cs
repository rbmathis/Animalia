using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelobatidae.Pelobates;

/// <summary>
/// Abstract class for Pelobates (genus).
/// NCBI TaxId: 61615
/// </summary>
public abstract class Pelobates : Pelobatidae, IPelobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61615;

    /// <inheritdoc />
    public virtual string GenusName => "Pelobates";

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
