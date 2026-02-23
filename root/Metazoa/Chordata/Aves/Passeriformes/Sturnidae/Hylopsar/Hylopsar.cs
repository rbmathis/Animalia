using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Hylopsar;

/// <summary>
/// Abstract class for Hylopsar (genus).
/// NCBI TaxId: 3150834
/// </summary>
public abstract class Hylopsar : Sturnidae, IHylopsar
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylopsar";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150834;

    /// <inheritdoc />
    public virtual string GenusName => "Hylopsar";

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
