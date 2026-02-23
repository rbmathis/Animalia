using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Tropidophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Tropidophiidae.Trachyboa;

/// <summary>
/// Abstract class for Trachyboa (genus).
/// NCBI TaxId: 46283
/// </summary>
public abstract class Trachyboa : Tropidophiidae, ITrachyboa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachyboa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46283;

    /// <inheritdoc />
    public virtual string GenusName => "Trachyboa";

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
