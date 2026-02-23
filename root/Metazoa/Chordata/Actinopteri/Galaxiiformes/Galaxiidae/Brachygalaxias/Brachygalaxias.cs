using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Galaxiiformes.Galaxiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Galaxiiformes.Galaxiidae.Brachygalaxias;

/// <summary>
/// Abstract class for Brachygalaxias (genus).
/// NCBI TaxId: 89579
/// </summary>
public abstract class Brachygalaxias : Galaxiidae, IBrachygalaxias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachygalaxias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89579;

    /// <inheritdoc />
    public virtual string GenusName => "Brachygalaxias";

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
