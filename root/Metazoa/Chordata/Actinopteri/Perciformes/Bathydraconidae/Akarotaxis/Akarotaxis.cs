using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bathydraconidae.Akarotaxis;

/// <summary>
/// Abstract class for Akarotaxis (genus).
/// NCBI TaxId: 227740
/// </summary>
public abstract class Akarotaxis : Bathydraconidae, IAkarotaxis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Akarotaxis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 227740;

    /// <inheritdoc />
    public virtual string GenusName => "Akarotaxis";

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
