using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Rankinia;

/// <summary>
/// Abstract class for Rankinia (genus).
/// NCBI TaxId: 118248
/// </summary>
public abstract class Rankinia : Agamidae, IRankinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rankinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118248;

    /// <inheritdoc />
    public virtual string GenusName => "Rankinia";

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
