using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Argyrophis;

/// <summary>
/// Abstract class for Argyrophis (genus).
/// NCBI TaxId: 1539852
/// </summary>
public abstract class Argyrophis : Typhlopidae, IArgyrophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Argyrophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1539852;

    /// <inheritdoc />
    public virtual string GenusName => "Argyrophis";

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
