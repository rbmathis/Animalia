using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Magliophis;

/// <summary>
/// Abstract class for Magliophis (genus).
/// NCBI TaxId: 1335305
/// </summary>
public abstract class Magliophis : Dipsadidae, IMagliophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Magliophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1335305;

    /// <inheritdoc />
    public virtual string GenusName => "Magliophis";

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
