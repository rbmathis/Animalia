using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Xenisthmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Xenisthmidae.Tyson;

/// <summary>
/// Abstract class for Tyson (genus).
/// NCBI TaxId: 2589282
/// </summary>
public abstract class Tyson : Xenisthmidae, ITyson
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tyson";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2589282;

    /// <inheritdoc />
    public virtual string GenusName => "Tyson";

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
