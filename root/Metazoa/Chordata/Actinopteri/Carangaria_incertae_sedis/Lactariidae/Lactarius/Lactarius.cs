using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Lactariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Lactariidae.Lactarius;

/// <summary>
/// Abstract class for Lactarius (genus).
/// NCBI TaxId: 210571
/// </summary>
public abstract class Lactarius : Lactariidae, ILactarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lactarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210571;

    /// <inheritdoc />
    public virtual string GenusName => "Lactarius";

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
