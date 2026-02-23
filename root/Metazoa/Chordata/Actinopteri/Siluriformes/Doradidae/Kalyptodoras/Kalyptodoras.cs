using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Kalyptodoras;

/// <summary>
/// Abstract class for Kalyptodoras (genus).
/// NCBI TaxId: 1312659
/// </summary>
public abstract class Kalyptodoras : Doradidae, IKalyptodoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kalyptodoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1312659;

    /// <inheritdoc />
    public virtual string GenusName => "Kalyptodoras";

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
