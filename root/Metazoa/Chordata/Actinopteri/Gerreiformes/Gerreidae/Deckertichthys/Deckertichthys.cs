using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae.Deckertichthys;

/// <summary>
/// Abstract class for Deckertichthys (genus).
/// NCBI TaxId: 3362341
/// </summary>
public abstract class Deckertichthys : Gerreidae, IDeckertichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Deckertichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362341;

    /// <inheritdoc />
    public virtual string GenusName => "Deckertichthys";

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
