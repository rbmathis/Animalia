using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pentacerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pentacerotidae.Paristiopterus;

/// <summary>
/// Abstract class for Paristiopterus (genus).
/// NCBI TaxId: 334881
/// </summary>
public abstract class Paristiopterus : Pentacerotidae, IParistiopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paristiopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 334881;

    /// <inheritdoc />
    public virtual string GenusName => "Paristiopterus";

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
