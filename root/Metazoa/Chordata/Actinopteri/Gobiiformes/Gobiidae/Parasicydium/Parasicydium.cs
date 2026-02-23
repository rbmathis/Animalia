using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Parasicydium;

/// <summary>
/// Abstract class for Parasicydium (genus).
/// NCBI TaxId: 1410060
/// </summary>
public abstract class Parasicydium : Gobiidae, IParasicydium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parasicydium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1410060;

    /// <inheritdoc />
    public virtual string GenusName => "Parasicydium";

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
