using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Calyptocephalellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Calyptocephalellidae.Telmatobufo;

/// <summary>
/// Abstract class for Telmatobufo (genus).
/// NCBI TaxId: 93482
/// </summary>
public abstract class Telmatobufo : Calyptocephalellidae, ITelmatobufo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Telmatobufo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 93482;

    /// <inheritdoc />
    public virtual string GenusName => "Telmatobufo";

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
