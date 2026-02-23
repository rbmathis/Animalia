using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Milyeringidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Milyeringidae.Milyeringa;

/// <summary>
/// Abstract class for Milyeringa (genus).
/// NCBI TaxId: 308091
/// </summary>
public abstract class Milyeringa : Milyeringidae, IMilyeringa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Milyeringa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 308091;

    /// <inheritdoc />
    public virtual string GenusName => "Milyeringa";

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
