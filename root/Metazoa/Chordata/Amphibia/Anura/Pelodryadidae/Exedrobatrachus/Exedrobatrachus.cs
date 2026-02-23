using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Exedrobatrachus;

/// <summary>
/// Abstract class for Exedrobatrachus (genus).
/// NCBI TaxId: 3680992
/// </summary>
public abstract class Exedrobatrachus : Pelodryadidae, IExedrobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Exedrobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3680992;

    /// <inheritdoc />
    public virtual string GenusName => "Exedrobatrachus";

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
