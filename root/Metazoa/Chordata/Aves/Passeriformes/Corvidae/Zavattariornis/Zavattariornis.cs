using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Zavattariornis;

/// <summary>
/// Abstract class for Zavattariornis (genus).
/// NCBI TaxId: 257848
/// </summary>
public abstract class Zavattariornis : Corvidae, IZavattariornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zavattariornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 257848;

    /// <inheritdoc />
    public virtual string GenusName => "Zavattariornis";

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
