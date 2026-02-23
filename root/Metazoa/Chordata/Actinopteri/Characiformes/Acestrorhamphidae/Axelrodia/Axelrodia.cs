using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Axelrodia;

/// <summary>
/// Abstract class for Axelrodia (genus).
/// NCBI TaxId: 1739087
/// </summary>
public abstract class Axelrodia : Acestrorhamphidae, IAxelrodia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Axelrodia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1739087;

    /// <inheritdoc />
    public virtual string GenusName => "Axelrodia";

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
