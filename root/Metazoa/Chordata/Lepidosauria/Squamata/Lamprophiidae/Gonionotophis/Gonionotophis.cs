using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Gonionotophis;

/// <summary>
/// Abstract class for Gonionotophis (genus).
/// NCBI TaxId: 292900
/// </summary>
public abstract class Gonionotophis : Lamprophiidae, IGonionotophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gonionotophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 292900;

    /// <inheritdoc />
    public virtual string GenusName => "Gonionotophis";

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
