using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae.Bathylychnops;

/// <summary>
/// Abstract class for Bathylychnops (genus).
/// NCBI TaxId: 473349
/// </summary>
public abstract class Bathylychnops : Opisthoproctidae, IBathylychnops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathylychnops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 473349;

    /// <inheritdoc />
    public virtual string GenusName => "Bathylychnops";

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
