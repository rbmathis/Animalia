using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Harttia;

/// <summary>
/// Abstract class for Harttia (genus).
/// NCBI TaxId: 503137
/// </summary>
public abstract class Harttia : Loricariidae, IHarttia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Harttia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 503137;

    /// <inheritdoc />
    public virtual string GenusName => "Harttia";

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
