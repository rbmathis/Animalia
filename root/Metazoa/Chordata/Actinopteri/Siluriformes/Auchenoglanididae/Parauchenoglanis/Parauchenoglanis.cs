using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenoglanididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenoglanididae.Parauchenoglanis;

/// <summary>
/// Abstract class for Parauchenoglanis (genus).
/// NCBI TaxId: 337542
/// </summary>
public abstract class Parauchenoglanis : Auchenoglanididae, IParauchenoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parauchenoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337542;

    /// <inheritdoc />
    public virtual string GenusName => "Parauchenoglanis";

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
