using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Centromochlus;

/// <summary>
/// Abstract class for Centromochlus (genus).
/// NCBI TaxId: 238679
/// </summary>
public abstract class Centromochlus : Auchenipteridae, ICentromochlus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centromochlus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238679;

    /// <inheritdoc />
    public virtual string GenusName => "Centromochlus";

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
