using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Amnihyla;

/// <summary>
/// Abstract class for Amnihyla (genus).
/// NCBI TaxId: 3680984
/// </summary>
public abstract class Amnihyla : Pelodryadidae, IAmnihyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amnihyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3680984;

    /// <inheritdoc />
    public virtual string GenusName => "Amnihyla";

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
