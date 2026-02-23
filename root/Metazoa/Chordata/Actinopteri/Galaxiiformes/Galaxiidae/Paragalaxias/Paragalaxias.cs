using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Galaxiiformes.Galaxiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Galaxiiformes.Galaxiidae.Paragalaxias;

/// <summary>
/// Abstract class for Paragalaxias (genus).
/// NCBI TaxId: 89562
/// </summary>
public abstract class Paragalaxias : Galaxiidae, IParagalaxias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paragalaxias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89562;

    /// <inheritdoc />
    public virtual string GenusName => "Paragalaxias";

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
