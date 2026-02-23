using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Papuahyla;

/// <summary>
/// Abstract class for Papuahyla (genus).
/// NCBI TaxId: 3681002
/// </summary>
public abstract class Papuahyla : Pelodryadidae, IPapuahyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Papuahyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3681002;

    /// <inheritdoc />
    public virtual string GenusName => "Papuahyla";

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
