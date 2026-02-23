using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae.Hoplostethus;

/// <summary>
/// Abstract class for Hoplostethus (genus).
/// NCBI TaxId: 96777
/// </summary>
public abstract class Hoplostethus : Trachichthyidae, IHoplostethus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoplostethus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 96777;

    /// <inheritdoc />
    public virtual string GenusName => "Hoplostethus";

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
