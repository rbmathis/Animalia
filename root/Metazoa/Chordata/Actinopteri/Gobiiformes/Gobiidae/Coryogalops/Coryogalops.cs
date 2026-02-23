using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Coryogalops;

/// <summary>
/// Abstract class for Coryogalops (genus).
/// NCBI TaxId: 990269
/// </summary>
public abstract class Coryogalops : Gobiidae, ICoryogalops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coryogalops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990269;

    /// <inheritdoc />
    public virtual string GenusName => "Coryogalops";

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
