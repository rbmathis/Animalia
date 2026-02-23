using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Paralonchurus;

/// <summary>
/// Abstract class for Paralonchurus (genus).
/// NCBI TaxId: 1154681
/// </summary>
public abstract class Paralonchurus : Sciaenidae, IParalonchurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paralonchurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1154681;

    /// <inheritdoc />
    public virtual string GenusName => "Paralonchurus";

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
