using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Plotosus;

/// <summary>
/// Abstract class for Plotosus (genus).
/// NCBI TaxId: 243561
/// </summary>
public abstract class Plotosus : Plotosidae, IPlotosus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plotosus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 243561;

    /// <inheritdoc />
    public virtual string GenusName => "Plotosus";

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
