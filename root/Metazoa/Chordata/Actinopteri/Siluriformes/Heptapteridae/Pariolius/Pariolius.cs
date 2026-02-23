using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Pariolius;

/// <summary>
/// Abstract class for Pariolius (genus).
/// NCBI TaxId: 2709348
/// </summary>
public abstract class Pariolius : Heptapteridae, IPariolius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pariolius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2709348;

    /// <inheritdoc />
    public virtual string GenusName => "Pariolius";

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
