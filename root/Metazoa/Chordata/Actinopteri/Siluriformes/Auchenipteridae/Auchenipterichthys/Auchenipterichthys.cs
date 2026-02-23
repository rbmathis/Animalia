using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Auchenipterichthys;

/// <summary>
/// Abstract class for Auchenipterichthys (genus).
/// NCBI TaxId: 238664
/// </summary>
public abstract class Auchenipterichthys : Auchenipteridae, IAuchenipterichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Auchenipterichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238664;

    /// <inheritdoc />
    public virtual string GenusName => "Auchenipterichthys";

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
