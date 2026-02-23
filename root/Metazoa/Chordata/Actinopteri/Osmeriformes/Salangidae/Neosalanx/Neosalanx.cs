using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Salangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Salangidae.Neosalanx;

/// <summary>
/// Abstract class for Neosalanx (genus).
/// NCBI TaxId: 182235
/// </summary>
public abstract class Neosalanx : Salangidae, INeosalanx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neosalanx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182235;

    /// <inheritdoc />
    public virtual string GenusName => "Neosalanx";

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
