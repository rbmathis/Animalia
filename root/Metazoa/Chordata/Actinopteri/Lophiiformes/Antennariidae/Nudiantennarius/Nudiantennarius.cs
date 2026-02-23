using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Nudiantennarius;

/// <summary>
/// Abstract class for Nudiantennarius (genus).
/// NCBI TaxId: 2923236
/// </summary>
public abstract class Nudiantennarius : Antennariidae, INudiantennarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nudiantennarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2923236;

    /// <inheritdoc />
    public virtual string GenusName => "Nudiantennarius";

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
