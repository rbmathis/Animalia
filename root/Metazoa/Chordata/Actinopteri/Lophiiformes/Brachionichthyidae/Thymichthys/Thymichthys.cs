using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Brachionichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Brachionichthyidae.Thymichthys;

/// <summary>
/// Abstract class for Thymichthys (genus).
/// NCBI TaxId: 3119966
/// </summary>
public abstract class Thymichthys : Brachionichthyidae, IThymichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thymichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3119966;

    /// <inheritdoc />
    public virtual string GenusName => "Thymichthys";

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
