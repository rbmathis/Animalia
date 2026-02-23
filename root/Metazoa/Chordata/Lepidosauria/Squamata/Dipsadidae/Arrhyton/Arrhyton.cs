using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Arrhyton;

/// <summary>
/// Abstract class for Arrhyton (genus).
/// NCBI TaxId: 121304
/// </summary>
public abstract class Arrhyton : Dipsadidae, IArrhyton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arrhyton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121304;

    /// <inheritdoc />
    public virtual string GenusName => "Arrhyton";

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
