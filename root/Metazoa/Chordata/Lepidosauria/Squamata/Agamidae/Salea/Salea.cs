using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Salea;

/// <summary>
/// Abstract class for Salea (genus).
/// NCBI TaxId: 118232
/// </summary>
public abstract class Salea : Agamidae, ISalea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Salea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118232;

    /// <inheritdoc />
    public virtual string GenusName => "Salea";

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
