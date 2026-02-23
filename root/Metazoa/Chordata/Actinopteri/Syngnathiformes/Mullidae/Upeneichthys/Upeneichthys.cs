using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae.Upeneichthys;

/// <summary>
/// Abstract class for Upeneichthys (genus).
/// NCBI TaxId: 334901
/// </summary>
public abstract class Upeneichthys : Mullidae, IUpeneichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Upeneichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 334901;

    /// <inheritdoc />
    public virtual string GenusName => "Upeneichthys";

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
