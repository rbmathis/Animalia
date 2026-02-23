using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Corvula;

/// <summary>
/// Abstract class for Corvula (genus).
/// NCBI TaxId: 1642205
/// </summary>
public abstract class Corvula : Sciaenidae, ICorvula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Corvula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1642205;

    /// <inheritdoc />
    public virtual string GenusName => "Corvula";

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
