using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Polychrotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Polychrotidae.Polychrus;

/// <summary>
/// Abstract class for Polychrus (genus).
/// NCBI TaxId: 38933
/// </summary>
public abstract class Polychrus : Polychrotidae, IPolychrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polychrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38933;

    /// <inheritdoc />
    public virtual string GenusName => "Polychrus";

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
