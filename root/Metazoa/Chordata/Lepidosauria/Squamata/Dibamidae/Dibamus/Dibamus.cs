using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dibamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dibamidae.Dibamus;

/// <summary>
/// Abstract class for Dibamus (genus).
/// NCBI TaxId: 261509
/// </summary>
public abstract class Dibamus : Dibamidae, IDibamus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dibamus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 261509;

    /// <inheritdoc />
    public virtual string GenusName => "Dibamus";

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
