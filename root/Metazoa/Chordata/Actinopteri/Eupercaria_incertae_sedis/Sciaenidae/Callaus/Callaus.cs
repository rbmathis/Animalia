using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Callaus;

/// <summary>
/// Abstract class for Callaus (genus).
/// NCBI TaxId: 3363396
/// </summary>
public abstract class Callaus : Sciaenidae, ICallaus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callaus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363396;

    /// <inheritdoc />
    public virtual string GenusName => "Callaus";

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
