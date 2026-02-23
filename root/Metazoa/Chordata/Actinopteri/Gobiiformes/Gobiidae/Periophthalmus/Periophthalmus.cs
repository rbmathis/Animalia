using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Periophthalmus;

/// <summary>
/// Abstract class for Periophthalmus (genus).
/// NCBI TaxId: 86204
/// </summary>
public abstract class Periophthalmus : Gobiidae, IPeriophthalmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Periophthalmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86204;

    /// <inheritdoc />
    public virtual string GenusName => "Periophthalmus";

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
