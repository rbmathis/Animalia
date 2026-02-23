using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ictaluridae.Pylodictis;

/// <summary>
/// Abstract class for Pylodictis (genus).
/// NCBI TaxId: 75287
/// </summary>
public abstract class Pylodictis : Ictaluridae, IPylodictis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pylodictis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75287;

    /// <inheritdoc />
    public virtual string GenusName => "Pylodictis";

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
