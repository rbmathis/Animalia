using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Hexanchiformes.Hexanchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Hexanchiformes.Hexanchidae.Heptranchias;

/// <summary>
/// Abstract class for Heptranchias (genus).
/// NCBI TaxId: 212739
/// </summary>
public abstract class Heptranchias : Hexanchidae, IHeptranchias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heptranchias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 212739;

    /// <inheritdoc />
    public virtual string GenusName => "Heptranchias";

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
