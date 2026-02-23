using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Caligavis;

/// <summary>
/// Abstract class for Caligavis (genus).
/// NCBI TaxId: 1921804
/// </summary>
public abstract class Caligavis : Meliphagidae, ICaligavis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caligavis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1921804;

    /// <inheritdoc />
    public virtual string GenusName => "Caligavis";

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
