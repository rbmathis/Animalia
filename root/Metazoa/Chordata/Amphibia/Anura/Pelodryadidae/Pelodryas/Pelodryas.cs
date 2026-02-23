using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Pelodryas;

/// <summary>
/// Abstract class for Pelodryas (genus).
/// NCBI TaxId: 3570142
/// </summary>
public abstract class Pelodryas : Pelodryadidae, IPelodryas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelodryas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3570142;

    /// <inheritdoc />
    public virtual string GenusName => "Pelodryas";

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
