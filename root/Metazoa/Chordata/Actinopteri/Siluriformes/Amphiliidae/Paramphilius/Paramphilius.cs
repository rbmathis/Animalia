using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Paramphilius;

/// <summary>
/// Abstract class for Paramphilius (genus).
/// NCBI TaxId: 1233696
/// </summary>
public abstract class Paramphilius : Amphiliidae, IParamphilius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paramphilius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1233696;

    /// <inheritdoc />
    public virtual string GenusName => "Paramphilius";

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
