using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Dicrodon;

/// <summary>
/// Abstract class for Dicrodon (genus).
/// NCBI TaxId: 171161
/// </summary>
public abstract class Dicrodon : Teiidae, IDicrodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dicrodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 171161;

    /// <inheritdoc />
    public virtual string GenusName => "Dicrodon";

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
