using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Calamodontophis;

/// <summary>
/// Abstract class for Calamodontophis (genus).
/// NCBI TaxId: 666074
/// </summary>
public abstract class Calamodontophis : Dipsadidae, ICalamodontophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calamodontophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 666074;

    /// <inheritdoc />
    public virtual string GenusName => "Calamodontophis";

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
