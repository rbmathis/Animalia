using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Sholicola;

/// <summary>
/// Abstract class for Sholicola (genus).
/// NCBI TaxId: 1960645
/// </summary>
public abstract class Sholicola : Muscicapidae, ISholicola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sholicola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1960645;

    /// <inheritdoc />
    public virtual string GenusName => "Sholicola";

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
