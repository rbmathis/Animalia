using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Feia;

/// <summary>
/// Abstract class for Feia (genus).
/// NCBI TaxId: 1365683
/// </summary>
public abstract class Feia : Gobiidae, IFeia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Feia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365683;

    /// <inheritdoc />
    public virtual string GenusName => "Feia";

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
