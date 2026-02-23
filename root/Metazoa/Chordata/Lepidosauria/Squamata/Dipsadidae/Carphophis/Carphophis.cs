using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Carphophis;

/// <summary>
/// Abstract class for Carphophis (genus).
/// NCBI TaxId: 186575
/// </summary>
public abstract class Carphophis : Dipsadidae, ICarphophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carphophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186575;

    /// <inheritdoc />
    public virtual string GenusName => "Carphophis";

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
