using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Trachycorystes;

/// <summary>
/// Abstract class for Trachycorystes (genus).
/// NCBI TaxId: 1312670
/// </summary>
public abstract class Trachycorystes : Auchenipteridae, ITrachycorystes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachycorystes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1312670;

    /// <inheritdoc />
    public virtual string GenusName => "Trachycorystes";

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
