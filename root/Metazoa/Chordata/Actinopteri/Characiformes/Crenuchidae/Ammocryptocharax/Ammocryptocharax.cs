using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Ammocryptocharax;

/// <summary>
/// Abstract class for Ammocryptocharax (genus).
/// NCBI TaxId: 1569730
/// </summary>
public abstract class Ammocryptocharax : Crenuchidae, IAmmocryptocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ammocryptocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1569730;

    /// <inheritdoc />
    public virtual string GenusName => "Ammocryptocharax";

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
