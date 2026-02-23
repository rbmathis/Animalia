using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Mitophis;

/// <summary>
/// Abstract class for Mitophis (genus).
/// NCBI TaxId: 711073
/// </summary>
public abstract class Mitophis : Leptotyphlopidae, IMitophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mitophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 711073;

    /// <inheritdoc />
    public virtual string GenusName => "Mitophis";

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
