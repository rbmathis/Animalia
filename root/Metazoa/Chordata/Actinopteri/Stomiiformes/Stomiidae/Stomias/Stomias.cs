using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Stomias;

/// <summary>
/// Abstract class for Stomias (genus).
/// NCBI TaxId: 320410
/// </summary>
public abstract class Stomias : Stomiidae, IStomias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stomias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320410;

    /// <inheritdoc />
    public virtual string GenusName => "Stomias";

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
