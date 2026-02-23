using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Leptorhamdia;

/// <summary>
/// Abstract class for Leptorhamdia (genus).
/// NCBI TaxId: 2821907
/// </summary>
public abstract class Leptorhamdia : Heptapteridae, ILeptorhamdia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptorhamdia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821907;

    /// <inheritdoc />
    public virtual string GenusName => "Leptorhamdia";

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
