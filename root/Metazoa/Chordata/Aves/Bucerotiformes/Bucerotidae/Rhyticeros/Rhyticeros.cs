using AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Rhyticeros;

/// <summary>
/// Abstract class for Rhyticeros (genus).
/// NCBI TaxId: 866436
/// </summary>
public abstract class Rhyticeros : Bucerotidae, IRhyticeros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhyticeros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 866436;

    /// <inheritdoc />
    public virtual string GenusName => "Rhyticeros";

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
