using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenoglanididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenoglanididae.Anaspidoglanis;

/// <summary>
/// Abstract class for Anaspidoglanis (genus).
/// NCBI TaxId: 390415
/// </summary>
public abstract class Anaspidoglanis : Auchenoglanididae, IAnaspidoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anaspidoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390415;

    /// <inheritdoc />
    public virtual string GenusName => "Anaspidoglanis";

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
