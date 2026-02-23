using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Cynoscion;

/// <summary>
/// Abstract class for Cynoscion (genus).
/// NCBI TaxId: 13028
/// </summary>
public abstract class Cynoscion : Sciaenidae, ICynoscion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cynoscion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13028;

    /// <inheritdoc />
    public virtual string GenusName => "Cynoscion";

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
