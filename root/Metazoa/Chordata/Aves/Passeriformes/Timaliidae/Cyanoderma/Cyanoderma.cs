using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Cyanoderma;

/// <summary>
/// Abstract class for Cyanoderma (genus).
/// NCBI TaxId: 2614578
/// </summary>
public abstract class Cyanoderma : Timaliidae, ICyanoderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyanoderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2614578;

    /// <inheritdoc />
    public virtual string GenusName => "Cyanoderma";

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
