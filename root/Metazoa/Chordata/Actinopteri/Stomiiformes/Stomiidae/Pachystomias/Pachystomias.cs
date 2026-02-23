using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Pachystomias;

/// <summary>
/// Abstract class for Pachystomias (genus).
/// NCBI TaxId: 436883
/// </summary>
public abstract class Pachystomias : Stomiidae, IPachystomias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachystomias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 436883;

    /// <inheritdoc />
    public virtual string GenusName => "Pachystomias";

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
