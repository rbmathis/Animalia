using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Crisantophis;

/// <summary>
/// Abstract class for Crisantophis (genus).
/// NCBI TaxId: 758874
/// </summary>
public abstract class Crisantophis : Dipsadidae, ICrisantophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crisantophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 758874;

    /// <inheritdoc />
    public virtual string GenusName => "Crisantophis";

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
