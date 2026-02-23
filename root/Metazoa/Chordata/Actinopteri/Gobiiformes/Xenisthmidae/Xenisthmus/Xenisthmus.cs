using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Xenisthmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Xenisthmidae.Xenisthmus;

/// <summary>
/// Abstract class for Xenisthmus (genus).
/// NCBI TaxId: 86215
/// </summary>
public abstract class Xenisthmus : Xenisthmidae, IXenisthmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenisthmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86215;

    /// <inheritdoc />
    public virtual string GenusName => "Xenisthmus";

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
