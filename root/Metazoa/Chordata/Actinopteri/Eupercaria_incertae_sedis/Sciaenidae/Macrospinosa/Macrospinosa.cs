using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Macrospinosa;

/// <summary>
/// Abstract class for Macrospinosa (genus).
/// NCBI TaxId: 1218031
/// </summary>
public abstract class Macrospinosa : Sciaenidae, IMacrospinosa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrospinosa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1218031;

    /// <inheritdoc />
    public virtual string GenusName => "Macrospinosa";

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
