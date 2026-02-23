using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Epactionotus;

/// <summary>
/// Abstract class for Epactionotus (genus).
/// NCBI TaxId: 510747
/// </summary>
public abstract class Epactionotus : Loricariidae, IEpactionotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Epactionotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 510747;

    /// <inheritdoc />
    public virtual string GenusName => "Epactionotus";

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
