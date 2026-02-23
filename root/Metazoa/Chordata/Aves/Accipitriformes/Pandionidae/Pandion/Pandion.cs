using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Pandionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Pandionidae.Pandion;

/// <summary>
/// Abstract class for Pandion (genus).
/// NCBI TaxId: 56261
/// </summary>
public abstract class Pandion : Pandionidae, IPandion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pandion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56261;

    /// <inheritdoc />
    public virtual string GenusName => "Pandion";

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
