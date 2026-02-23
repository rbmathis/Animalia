using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Veniliornis;

/// <summary>
/// Abstract class for Veniliornis (genus).
/// NCBI TaxId: 56075
/// </summary>
public abstract class Veniliornis : Picidae, IVeniliornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Veniliornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56075;

    /// <inheritdoc />
    public virtual string GenusName => "Veniliornis";

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
