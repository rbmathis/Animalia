using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelobatidae.Scaphiopus;

/// <summary>
/// Abstract class for Scaphiopus (genus).
/// NCBI TaxId: 8434
/// </summary>
public abstract class Scaphiopus : Pelobatidae, IScaphiopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scaphiopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8434;

    /// <inheritdoc />
    public virtual string GenusName => "Scaphiopus";

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
