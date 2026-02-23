using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae.Optivus;

/// <summary>
/// Abstract class for Optivus (genus).
/// NCBI TaxId: 2578397
/// </summary>
public abstract class Optivus : Trachichthyidae, IOptivus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Optivus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2578397;

    /// <inheritdoc />
    public virtual string GenusName => "Optivus";

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
