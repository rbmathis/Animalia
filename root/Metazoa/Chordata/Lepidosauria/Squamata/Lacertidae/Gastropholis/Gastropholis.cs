using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Gastropholis;

/// <summary>
/// Abstract class for Gastropholis (genus).
/// NCBI TaxId: 1075114
/// </summary>
public abstract class Gastropholis : Lacertidae, IGastropholis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gastropholis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1075114;

    /// <inheritdoc />
    public virtual string GenusName => "Gastropholis";

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
