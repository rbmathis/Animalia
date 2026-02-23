using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae.Eleutheronema;

/// <summary>
/// Abstract class for Eleutheronema (genus).
/// NCBI TaxId: 210138
/// </summary>
public abstract class Eleutheronema : Polynemidae, IEleutheronema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eleutheronema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210138;

    /// <inheritdoc />
    public virtual string GenusName => "Eleutheronema";

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
