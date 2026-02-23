using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bombycillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bombycillidae.Bombycilla;

/// <summary>
/// Abstract class for Bombycilla (genus).
/// NCBI TaxId: 125296
/// </summary>
public abstract class Bombycilla : Bombycillidae, IBombycilla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bombycilla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125296;

    /// <inheritdoc />
    public virtual string GenusName => "Bombycilla";

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
