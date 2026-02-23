using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Galvarinus;

/// <summary>
/// Abstract class for Galvarinus (genus).
/// NCBI TaxId: 2982188
/// </summary>
public abstract class Galvarinus : Dipsadidae, IGalvarinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Galvarinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2982188;

    /// <inheritdoc />
    public virtual string GenusName => "Galvarinus";

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
