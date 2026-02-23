using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Platygobiopsis;

/// <summary>
/// Abstract class for Platygobiopsis (genus).
/// NCBI TaxId: 2768309
/// </summary>
public abstract class Platygobiopsis : Gobiidae, IPlatygobiopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platygobiopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2768309;

    /// <inheritdoc />
    public virtual string GenusName => "Platygobiopsis";

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
