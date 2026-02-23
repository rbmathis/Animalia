using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Aulopareia;

/// <summary>
/// Abstract class for Aulopareia (genus).
/// NCBI TaxId: 2698443
/// </summary>
public abstract class Aulopareia : Gobiidae, IAulopareia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aulopareia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2698443;

    /// <inheritdoc />
    public virtual string GenusName => "Aulopareia";

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
