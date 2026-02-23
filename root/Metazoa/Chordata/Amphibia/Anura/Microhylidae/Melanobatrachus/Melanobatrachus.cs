using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Melanobatrachus;

/// <summary>
/// Abstract class for Melanobatrachus (genus).
/// NCBI TaxId: 419652
/// </summary>
public abstract class Melanobatrachus : Microhylidae, IMelanobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 419652;

    /// <inheritdoc />
    public virtual string GenusName => "Melanobatrachus";

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
