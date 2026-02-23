using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Roncador;

/// <summary>
/// Abstract class for Roncador (genus).
/// NCBI TaxId: 320397
/// </summary>
public abstract class Roncador : Sciaenidae, IRoncador
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Roncador";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320397;

    /// <inheritdoc />
    public virtual string GenusName => "Roncador";

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
