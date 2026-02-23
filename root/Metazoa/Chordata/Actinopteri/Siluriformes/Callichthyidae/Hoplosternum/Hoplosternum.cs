using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae.Hoplosternum;

/// <summary>
/// Abstract class for Hoplosternum (genus).
/// NCBI TaxId: 114108
/// </summary>
public abstract class Hoplosternum : Callichthyidae, IHoplosternum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoplosternum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114108;

    /// <inheritdoc />
    public virtual string GenusName => "Hoplosternum";

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
