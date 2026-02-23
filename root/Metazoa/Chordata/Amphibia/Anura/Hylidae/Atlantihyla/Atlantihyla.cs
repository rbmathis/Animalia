using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Atlantihyla;

/// <summary>
/// Abstract class for Atlantihyla (genus).
/// NCBI TaxId: 2491335
/// </summary>
public abstract class Atlantihyla : Hylidae, IAtlantihyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atlantihyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2491335;

    /// <inheritdoc />
    public virtual string GenusName => "Atlantihyla";

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
