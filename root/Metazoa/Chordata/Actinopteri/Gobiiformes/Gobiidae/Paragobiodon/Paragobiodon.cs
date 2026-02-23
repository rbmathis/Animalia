using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Paragobiodon;

/// <summary>
/// Abstract class for Paragobiodon (genus).
/// NCBI TaxId: 264363
/// </summary>
public abstract class Paragobiodon : Gobiidae, IParagobiodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paragobiodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 264363;

    /// <inheritdoc />
    public virtual string GenusName => "Paragobiodon";

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
