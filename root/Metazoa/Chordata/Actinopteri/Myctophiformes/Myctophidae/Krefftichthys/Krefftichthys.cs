using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Krefftichthys;

/// <summary>
/// Abstract class for Krefftichthys (genus).
/// NCBI TaxId: 123329
/// </summary>
public abstract class Krefftichthys : Myctophidae, IKrefftichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Krefftichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123329;

    /// <inheritdoc />
    public virtual string GenusName => "Krefftichthys";

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
