using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Leptobatrachus;

/// <summary>
/// Abstract class for Leptobatrachus (genus).
/// NCBI TaxId: 3680998
/// </summary>
public abstract class Leptobatrachus : Pelodryadidae, ILeptobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3680998;

    /// <inheritdoc />
    public virtual string GenusName => "Leptobatrachus";

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
