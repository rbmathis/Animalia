using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Iberolacerta;

/// <summary>
/// Abstract class for Iberolacerta (genus).
/// NCBI TaxId: 176665
/// </summary>
public abstract class Iberolacerta : Lacertidae, IIberolacerta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Iberolacerta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176665;

    /// <inheritdoc />
    public virtual string GenusName => "Iberolacerta";

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
