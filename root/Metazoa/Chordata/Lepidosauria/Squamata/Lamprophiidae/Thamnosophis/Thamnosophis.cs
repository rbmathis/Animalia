using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Thamnosophis;

/// <summary>
/// Abstract class for Thamnosophis (genus).
/// NCBI TaxId: 641492
/// </summary>
public abstract class Thamnosophis : Lamprophiidae, IThamnosophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thamnosophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 641492;

    /// <inheritdoc />
    public virtual string GenusName => "Thamnosophis";

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
