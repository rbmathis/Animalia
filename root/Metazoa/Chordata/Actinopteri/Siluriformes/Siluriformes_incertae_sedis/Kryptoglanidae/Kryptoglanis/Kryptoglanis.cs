using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluriformes_incertae_sedis.Kryptoglanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluriformes_incertae_sedis.Kryptoglanidae.Kryptoglanis;

/// <summary>
/// Abstract class for Kryptoglanis (genus).
/// NCBI TaxId: 748430
/// </summary>
public abstract class Kryptoglanis : Kryptoglanidae, IKryptoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kryptoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 748430;

    /// <inheritdoc />
    public virtual string GenusName => "Kryptoglanis";

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
