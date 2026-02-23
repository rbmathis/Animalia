using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Ditypophis;

/// <summary>
/// Abstract class for Ditypophis (genus).
/// NCBI TaxId: 224543
/// </summary>
public abstract class Ditypophis : Lamprophiidae, IDitypophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ditypophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 224543;

    /// <inheritdoc />
    public virtual string GenusName => "Ditypophis";

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
