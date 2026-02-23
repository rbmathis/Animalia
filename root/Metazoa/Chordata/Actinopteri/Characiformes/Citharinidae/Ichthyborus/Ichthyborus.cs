using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Citharinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Citharinidae.Ichthyborus;

/// <summary>
/// Abstract class for Ichthyborus (genus).
/// NCBI TaxId: 304035
/// </summary>
public abstract class Ichthyborus : Citharinidae, IIchthyborus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ichthyborus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304035;

    /// <inheritdoc />
    public virtual string GenusName => "Ichthyborus";

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
