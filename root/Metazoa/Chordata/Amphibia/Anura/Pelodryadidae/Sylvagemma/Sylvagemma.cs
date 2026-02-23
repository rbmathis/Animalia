using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Sylvagemma;

/// <summary>
/// Abstract class for Sylvagemma (genus).
/// NCBI TaxId: 3681008
/// </summary>
public abstract class Sylvagemma : Pelodryadidae, ISylvagemma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sylvagemma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3681008;

    /// <inheritdoc />
    public virtual string GenusName => "Sylvagemma";

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
