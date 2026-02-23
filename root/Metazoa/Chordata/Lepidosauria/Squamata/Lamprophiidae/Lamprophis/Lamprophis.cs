using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Lamprophis;

/// <summary>
/// Abstract class for Lamprophis (genus).
/// NCBI TaxId: 39148
/// </summary>
public abstract class Lamprophis : Lamprophiidae, ILamprophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lamprophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39148;

    /// <inheritdoc />
    public virtual string GenusName => "Lamprophis";

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
