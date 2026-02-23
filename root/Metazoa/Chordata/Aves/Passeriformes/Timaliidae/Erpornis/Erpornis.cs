using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Erpornis;

/// <summary>
/// Abstract class for Erpornis (genus).
/// NCBI TaxId: 1112835
/// </summary>
public abstract class Erpornis : Timaliidae, IErpornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erpornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1112835;

    /// <inheritdoc />
    public virtual string GenusName => "Erpornis";

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
