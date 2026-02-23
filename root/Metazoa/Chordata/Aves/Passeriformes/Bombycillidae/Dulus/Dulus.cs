using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bombycillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bombycillidae.Dulus;

/// <summary>
/// Abstract class for Dulus (genus).
/// NCBI TaxId: 161650
/// </summary>
public abstract class Dulus : Bombycillidae, IDulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161650;

    /// <inheritdoc />
    public virtual string GenusName => "Dulus";

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
