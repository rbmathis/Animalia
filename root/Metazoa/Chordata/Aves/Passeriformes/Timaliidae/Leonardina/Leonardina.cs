using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Leonardina;

/// <summary>
/// Abstract class for Leonardina (genus).
/// NCBI TaxId: 1149639
/// </summary>
public abstract class Leonardina : Timaliidae, ILeonardina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leonardina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1149639;

    /// <inheritdoc />
    public virtual string GenusName => "Leonardina";

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
