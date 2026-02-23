using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hisonotus;

/// <summary>
/// Abstract class for Hisonotus (genus).
/// NCBI TaxId: 321122
/// </summary>
public abstract class Hisonotus : Loricariidae, IHisonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hisonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 321122;

    /// <inheritdoc />
    public virtual string GenusName => "Hisonotus";

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
