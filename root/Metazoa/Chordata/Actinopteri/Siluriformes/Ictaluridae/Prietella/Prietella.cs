using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae.Prietella;

/// <summary>
/// Abstract class for Prietella (genus).
/// NCBI TaxId: 255565
/// </summary>
public abstract class Prietella : Ictaluridae, IPrietella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prietella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 255565;

    /// <inheritdoc />
    public virtual string GenusName => "Prietella";

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
