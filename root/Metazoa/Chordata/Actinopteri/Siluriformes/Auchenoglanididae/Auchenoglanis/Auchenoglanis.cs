using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenoglanididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenoglanididae.Auchenoglanis;

/// <summary>
/// Abstract class for Auchenoglanis (genus).
/// NCBI TaxId: 390417
/// </summary>
public abstract class Auchenoglanis : Auchenoglanididae, IAuchenoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Auchenoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390417;

    /// <inheritdoc />
    public virtual string GenusName => "Auchenoglanis";

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
