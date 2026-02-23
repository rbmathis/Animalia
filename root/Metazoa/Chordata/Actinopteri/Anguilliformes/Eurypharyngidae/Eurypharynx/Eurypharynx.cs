using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Eurypharyngidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Eurypharyngidae.Eurypharynx;

/// <summary>
/// Abstract class for Eurypharynx (genus).
/// NCBI TaxId: 55116
/// </summary>
public abstract class Eurypharynx : Eurypharyngidae, IEurypharynx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eurypharynx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55116;

    /// <inheritdoc />
    public virtual string GenusName => "Eurypharynx";

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
