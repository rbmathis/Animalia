using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Petilipinnis;

/// <summary>
/// Abstract class for Petilipinnis (genus).
/// NCBI TaxId: 1563995
/// </summary>
public abstract class Petilipinnis : Sciaenidae, IPetilipinnis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petilipinnis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1563995;

    /// <inheritdoc />
    public virtual string GenusName => "Petilipinnis";

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
