using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Plesioptopoma;

/// <summary>
/// Abstract class for Plesioptopoma (genus).
/// NCBI TaxId: 1912255
/// </summary>
public abstract class Plesioptopoma : Loricariidae, IPlesioptopoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plesioptopoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1912255;

    /// <inheritdoc />
    public virtual string GenusName => "Plesioptopoma";

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
