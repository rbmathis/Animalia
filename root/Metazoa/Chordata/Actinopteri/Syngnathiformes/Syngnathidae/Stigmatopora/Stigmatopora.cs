using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Stigmatopora;

/// <summary>
/// Abstract class for Stigmatopora (genus).
/// NCBI TaxId: 161580
/// </summary>
public abstract class Stigmatopora : Syngnathidae, IStigmatopora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stigmatopora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161580;

    /// <inheritdoc />
    public virtual string GenusName => "Stigmatopora";

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
