using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae.Gephyroberyx;

/// <summary>
/// Abstract class for Gephyroberyx (genus).
/// NCBI TaxId: 114855
/// </summary>
public abstract class Gephyroberyx : Trachichthyidae, IGephyroberyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gephyroberyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114855;

    /// <inheritdoc />
    public virtual string GenusName => "Gephyroberyx";

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
