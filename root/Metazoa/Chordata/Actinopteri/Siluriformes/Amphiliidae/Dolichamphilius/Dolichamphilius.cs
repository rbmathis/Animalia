using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Dolichamphilius;

/// <summary>
/// Abstract class for Dolichamphilius (genus).
/// NCBI TaxId: 1233723
/// </summary>
public abstract class Dolichamphilius : Amphiliidae, IDolichamphilius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dolichamphilius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1233723;

    /// <inheritdoc />
    public virtual string GenusName => "Dolichamphilius";

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
