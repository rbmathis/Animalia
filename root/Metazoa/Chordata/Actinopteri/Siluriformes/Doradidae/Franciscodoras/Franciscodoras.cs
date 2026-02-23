using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Franciscodoras;

/// <summary>
/// Abstract class for Franciscodoras (genus).
/// NCBI TaxId: 1053608
/// </summary>
public abstract class Franciscodoras : Doradidae, IFranciscodoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Franciscodoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1053608;

    /// <inheritdoc />
    public virtual string GenusName => "Franciscodoras";

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
