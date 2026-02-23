using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Viridihyla;

/// <summary>
/// Abstract class for Viridihyla (genus).
/// NCBI TaxId: 3681083
/// </summary>
public abstract class Viridihyla : Pelodryadidae, IViridihyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Viridihyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3681083;

    /// <inheritdoc />
    public virtual string GenusName => "Viridihyla";

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
