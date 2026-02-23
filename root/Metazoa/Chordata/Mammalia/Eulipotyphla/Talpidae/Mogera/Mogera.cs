using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Mogera;

/// <summary>
/// Abstract class for Mogera (genus).
/// NCBI TaxId: 62294
/// </summary>
public abstract class Mogera : Talpidae, IMogera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mogera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62294;

    /// <inheritdoc />
    public virtual string GenusName => "Mogera";

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
