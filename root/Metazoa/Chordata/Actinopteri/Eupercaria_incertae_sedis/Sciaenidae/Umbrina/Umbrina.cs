using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Umbrina;

/// <summary>
/// Abstract class for Umbrina (genus).
/// NCBI TaxId: 94954
/// </summary>
public abstract class Umbrina : Sciaenidae, IUmbrina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Umbrina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94954;

    /// <inheritdoc />
    public virtual string GenusName => "Umbrina";

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
