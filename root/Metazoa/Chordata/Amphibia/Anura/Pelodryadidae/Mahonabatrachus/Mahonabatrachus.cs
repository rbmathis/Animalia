using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Mahonabatrachus;

/// <summary>
/// Abstract class for Mahonabatrachus (genus).
/// NCBI TaxId: 3680999
/// </summary>
public abstract class Mahonabatrachus : Pelodryadidae, IMahonabatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mahonabatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3680999;

    /// <inheritdoc />
    public virtual string GenusName => "Mahonabatrachus";

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
