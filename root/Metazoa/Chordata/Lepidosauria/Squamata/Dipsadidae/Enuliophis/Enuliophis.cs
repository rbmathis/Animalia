using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Enuliophis;

/// <summary>
/// Abstract class for Enuliophis (genus).
/// NCBI TaxId: 1212706
/// </summary>
public abstract class Enuliophis : Dipsadidae, IEnuliophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Enuliophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1212706;

    /// <inheritdoc />
    public virtual string GenusName => "Enuliophis";

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
