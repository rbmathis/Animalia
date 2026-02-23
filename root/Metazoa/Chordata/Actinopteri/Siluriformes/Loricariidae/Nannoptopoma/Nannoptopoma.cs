using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Nannoptopoma;

/// <summary>
/// Abstract class for Nannoptopoma (genus).
/// NCBI TaxId: 571823
/// </summary>
public abstract class Nannoptopoma : Loricariidae, INannoptopoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nannoptopoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 571823;

    /// <inheritdoc />
    public virtual string GenusName => "Nannoptopoma";

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
